/****************************/
CREATE TRIGGER [Trigger_CheckFieldsNullCustomer]
	ON [dbo].[Customers]
	FOR INSERT, UPDATE
	AS
	DECLARE @fn AS NVARCHAR(20), @ln AS NVARCHAR(20), @phone AS NVARCHAR(50), @username AS NVARCHAR(30), @password AS NVARCHAR(30)
    SELECT @fn = i.firstname, @ln = i.lastname, @phone = i.phone, @username = i.username, @password = i.password
	 FROM INSERTED i
    IF (@fn is null or @fn = ''
		or @ln is null or @ln =''
		or @phone is null or @phone = ''
		or @username is null or @username = ''
		or @password is null or @password = ''	
		)
    BEGIN
        SET NOCOUNT ON
		RAISERROR ('Missing Fields. Cannot Sign Up, Please Try Again' ,16,1)
        ROLLBACK TRANSACTION;  
    END

/****************************/
CREATE TRIGGER [Trigger_Validate_Input_Customer]
	ON [dbo].[Customers]
	FOR INSERT, UPDATE
	AS
	DECLARE @pwd AS NVARCHAR(30), @usm AS NVARCHAR(30)
    SELECT @pwd = i.password, @usm = i.username
	 FROM INSERTED i
    IF (LEN(@pwd) <= 6 OR LEN(@usm) <= 6)
    BEGIN
        SET NOCOUNT ON
		RAISERROR ('Your input data is wrong by default structure' ,16,1)
		PRINT('Username or Password of Customer must be more than 6 characters')
        ROLLBACK TRANSACTION;  
    END

/****************************/
CREATE   PROCEDURE [dbo].[Procedure_addNewCustomer] 
       @fname                    NVARCHAR(20), 
	   @lname                    NVARCHAR(20), 
	   @photo                    IMAGE, 
	   @phone                    NVARCHAR(50), 
	   @username                 NVARCHAR(30), 
	   @passwd                   NVARCHAR(30)
AS 
BEGIN 
     SET NOCOUNT ON 
     INSERT INTO dbo.Customers
          (              
            firstname,                  
            lastname,                      
            photo,
			phone,
			username,
			password
          ) 
     VALUES 
          ( 
			@fname, 
			@lname, 
			@photo, 
			@phone, 
			@username, 
			@passwd
          ) 
END

/****************************/
CREATE   PROCEDURE [dbo].[Procedure_addNewReview] 
       @booking_id INT, 
       @customer_id INT,
       @comment NTEXT,
       @rating INT
AS
BEGIN 
     SET NOCOUNT ON 
     INSERT INTO dbo.Reviews
          ( 
            booking_id,
            customer_id,
            comment,
            rating
          ) 
     VALUES 
          ( 
			@booking_id, 
            @customer_id,
            @comment,
            @rating
          ) 
END

/****************************/
CREATE   PROCEDURE [dbo].[Procedure_createBooking] 
	   @customer_id              INT, 
	   @room_id                  INT, 
	   @booking_date             DATETIME, 
	   @return_date              DATETIME, 
	   @amount                   DECIMAL(18),
	   @overdue_fee				 DECIMAL(18)
AS 
BEGIN 
     SET NOCOUNT ON 
     INSERT INTO dbo.Booking
          (                            
            customer_id,                      
            room_id,
			booking_date,
			return_date,
			amount,
			overdue_fee
          ) 
     VALUES 
          (                
            @customer_id,                      
            @room_id,
			@booking_date,
			@return_date,
			@amount,
			@overdue_fee
          ) 
END

/****************************/
CREATE   PROCEDURE [dbo].[Procedure_updateAmount] 
       @booking_id INT,
       @overdue_fee    DECIMAL(18)
AS 
BEGIN 
     UPDATE dbo.Booking
     SET amount = amount + @overdue_fee
     WHERE booking_id = @booking_id
END

/****************************/
CREATE   PROCEDURE [dbo].[Procedure_updateCheckInData] 
       @booking_id INT,
       @checkin    NVARCHAR(20)
AS 
BEGIN 
     UPDATE dbo.Booking
     SET checkin = @checkin
     WHERE booking_id = @booking_id
END

/****************************/
CREATE   PROCEDURE [dbo].[Procedure_updateCheckOutData] 
       @booking_id INT,
       @checkout   NVARCHAR(20)
AS 
BEGIN 
     UPDATE dbo.Booking
     SET checkout = @checkout
     WHERE booking_id = @booking_id
     AND checkout IS NULL
END

/****************************/
CREATE   PROCEDURE [dbo].[Procedure_updateOverdue_fee] 
       @booking_id       INT,
       @overdue_fee      DECIMAL(18)
AS 
BEGIN 
     UPDATE dbo.Booking
     SET overdue_fee = @overdue_fee
     WHERE booking_id = @booking_id
END

/****************************/
CREATE   PROCEDURE [dbo].[Procedure_updateStatusofRoom] 
       @room_id       INT,
       @room_status   BIT
AS 
BEGIN 
     UPDATE dbo.Rooms
     SET room_status = @room_status
     WHERE room_id = @room_id
END

/****************************/
CREATE FUNCTION [dbo].[Function_getAllEmployee_Janitor]
(
	@janitor NVARCHAR(20)
)
RETURNS @returnTable TABLE
(
	emp_id INT,
	firstname NVARCHAR(20),
	lastname NVARCHAR(20),
	email NVARCHAR(30),
	bdate DATETIME,
	gender NVARCHAR(10),
	title NVARCHAR(20),
	photo IMAGE,
	phone NVARCHAR(40)
)
AS
BEGIN
	INSERT @returnTable
	SELECT *
	FROM Employees
	WHERE title = @janitor
	RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_getAllHistoryBooking_byID]
(
	@customer_id int
)
RETURNS @returnTable TABLE
(
	booking_id INT,
	room_id INT,
	booking_date DATE,
	return_date DATE,
	checkin DATETIME,
	checkout DATETIME,
	room_price DECIMAL(18),
	overdue_fee DECIMAL(18),
	amount DECIMAL(18)
)
AS
BEGIN
	INSERT @returnTable
	SELECT Booking.booking_id, Booking.room_id, Booking.booking_date, Booking.return_date, Booking.checkin,
		   Booking.checkout, room_price, overdue_fee,Booking.amount
	FROM Booking, Rooms, RoomTypes
	WHERE Booking.room_id = Rooms.room_id
	AND Rooms.room_type = RoomTypes.room_type_id
	RETURN
END

/****************************/
CREATE FUNCTION Function_getAllRooms()
RETURNS @returnTable TABLE
(
	room_id INT,
    type_name NVARCHAR(30),
    room_capacity INT,
    room_bed INT,
    room_price DECIMAL(18),
    status_name NVARCHAR(20)
)
AS
BEGIN
    INSERT @returnTable
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.room_capacity, RoomTypes.room_bed, RoomTypes.room_price
            , RoomStatus.status_name
    FROM Rooms, RoomTypes, RoomStatus
    WHERE Rooms.room_type = RoomTypes.room_type_id 
    AND Rooms.room_status = RoomStatus.status_id
    RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_getAllRooms_byTypes] 
(
    @room_type INT
)
RETURNS @returnTable TABLE
(
	room_id INT,
    type_name NVARCHAR(30),
    room_capacity INT,
    room_bed INT,
    room_price DECIMAL(18),
    status_name NVARCHAR(20)
)
AS
BEGIN
    INSERT @returnTable
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.room_capacity, RoomTypes.room_bed, RoomTypes.room_price
            , RoomStatus.status_name
    FROM Rooms, RoomTypes, RoomStatus
    WHERE Rooms.room_type = RoomTypes.room_type_id 
    AND Rooms.room_status = RoomStatus.status_id
    AND Rooms.room_type = @room_type
    RETURN
END

/****************************/
CREATE FUNCTION Function_getBooking
(
    @customer_id INT
)
RETURNS @returnTable TABLE
(
	booking_id INT,
    room_id INT,
    booking_date DATE,
    return_date DATE,
    checkin DATETIME,
    checkout DATETIME
)
AS
BEGIN
    INSERT @returnTable
    SELECT booking_id, room_id, booking_date, return_date, checkin, checkout
    FROM Booking
    WHERE customer_id = @customer_id
    AND checkout IS NULL
    RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_getCustomerbyID]
(
	@id int
)
RETURNS @returnTable TABLE
(
	customer_id INT,
	firstname NVARCHAR(20),
	lastname NVARCHAR(20),
	photo IMAGE,
	phone NVARCHAR(50),
	username NVARCHAR(30),
	password NVARCHAR(30)
)
AS
BEGIN
	INSERT @returnTable
	SELECT * FROM dbo.Customers WHERE dbo.Customers.customer_id = @id
	RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_getEmployee_byID]
(
	@emp_id NVARCHAR(20)
)
RETURNS @returnTable TABLE
(
	emp_id INT,
	firstname NVARCHAR(20),
	lastname NVARCHAR(20),
	email NVARCHAR(30),
	bdate DATETIME,
	gender NVARCHAR(10),
	title NVARCHAR(20),
	photo IMAGE,
	phone NVARCHAR(40)
)
AS
BEGIN
	INSERT @returnTable
	SELECT *
	FROM Employees
	WHERE emp_id = @emp_id
	RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_getInfoCustomerByRoomID]
(
	@room_id int
)
RETURNS @returnTable TABLE
(
	customer_id INT,
	firstname NVARCHAR(20),
	lastname NVARCHAR(20),
	photo IMAGE,
	phone NVARCHAR(50),
	username NVARCHAR(30),
	password NVARCHAR(30),
	booking_date DATETIME,
	return_date DATETIME
)
AS
BEGIN
	INSERT @returnTable
	SELECT Customers.customer_id, Customers.firstname, Customers.lastname, Customers.photo, Customers.phone,
			Customers.username, Customers.password, booking_date, return_date
	FROM Customers, (
						SELECT DISTINCT customer_id, booking_date, return_date
						FROM dbo.Booking
						WHERE room_id = @room_id
						AND checkout IS NULL
					) H
	WHERE H.customer_id = Customers.customer_id
	RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_getRoomType] ()
RETURNS @returnTable TABLE
(
	type_name NVARCHAR(30),
    room_type_id INT
)
AS
BEGIN
    INSERT @returnTable
    SELECT RoomTypes.type_name, RoomTypes.room_type_id
    FROM RoomTypes
    RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_getScheduleByUserId]
(
	@tnow DATETIME,
	@emp_id INT
)
RETURNS @returnTable TABLE
(
	Monday NVARCHAR(20),
	Tuesday NVARCHAR(20), 
	Wednesday NVARCHAR(20), 
	Thursday NVARCHAR(20), 
	Friday NVARCHAR(20), 
	Saturday NVARCHAR(20), 
	Sunday NVARCHAR(20)
)
AS
BEGIN
	INSERT @returnTable
	select Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday from  Schedules
	where Schedules.emp_id = @emp_id
	and date_start <= @tnow and date_end >= @tnow
	RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_searchData_Janitor]
(
	@title NVARCHAR(20),
	@colName NVARCHAR(30),
	@valueToFind NVARCHAR(50)
)
RETURNS @returnTable TABLE
(
	emp_id INT,
	firstname NVARCHAR(20),
	lastname NVARCHAR(20),
	email NVARCHAR(30),
	bdate DATETIME,
	gender NVARCHAR(10),
	title NVARCHAR(20),
	photo IMAGE,
	phone NVARCHAR(40)
)
AS
BEGIN
	IF(@colName = 'emp_id')
	BEGIN
		INSERT @returnTable
		SELECT *
		FROM Employees
		WHERE title = @title
		AND STR(emp_id) LIKE '%'+ @valueToFind + '%'
		RETURN
	END
	IF(@colName = 'firstname')
	BEGIN
		INSERT @returnTable
		SELECT *
		FROM Employees
		WHERE title = @title
		AND firstname LIKE '%'+ @valueToFind + '%'
		RETURN
	END
	IF(@colName = 'lastname')
	BEGIN
		INSERT @returnTable
		SELECT *
		FROM Employees
		WHERE title = @title
		AND lastname LIKE '%'+ @valueToFind + '%'
		RETURN
	END
	IF(@colName = 'email')
	BEGIN
		INSERT @returnTable
		SELECT *
		FROM Employees
		WHERE title = @title
		AND email LIKE '%'+ @valueToFind + '%'
		RETURN
	END
	IF(@colName = 'gender')
	BEGIN
		INSERT @returnTable
		SELECT *
		FROM Employees
		WHERE title = @title
		AND gender LIKE '%'+ @valueToFind + '%'
		RETURN
	END
	IF(@colName = 'phone')
	BEGIN
		INSERT @returnTable
		SELECT *
		FROM Employees
		WHERE title = @title
		AND phone LIKE '%'+ @valueToFind + '%'
		RETURN
	END
	RETURN
END

/****************************/
CREATE FUNCTION Function_searchData_Room
(
    @colName NVARCHAR(30),
    @valueToFind NVARCHAR(50)
)
RETURNS @returnTable TABLE
(
	room_id INT,
    type_name NVARCHAR(30),
    room_capacity INT,
    room_bed INT,
    room_price DECIMAL(18),
    status_name NVARCHAR(20)
)
AS
BEGIN
    IF(@colName = 'room_id')
    BEGIN
    INSERT @returnTable
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.room_capacity, RoomTypes.room_bed, RoomTypes.room_price
            , RoomStatus.status_name
    FROM Rooms, RoomTypes, RoomStatus
    WHERE Rooms.room_type = RoomTypes.room_type_id 
    AND Rooms.room_status = RoomStatus.status_id
    AND STR(room_id) LIKE '%'+ @valueToFind + '%'
    RETURN
    END
    IF(@colName = 'type_name')
    BEGIN
    INSERT @returnTable
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.room_capacity, RoomTypes.room_bed, RoomTypes.room_price
            , RoomStatus.status_name
    FROM Rooms, RoomTypes, RoomStatus
    WHERE Rooms.room_type = RoomTypes.room_type_id 
    AND Rooms.room_status = RoomStatus.status_id
    AND type_name LIKE '%'+ @valueToFind + '%'
    RETURN
    END
    IF(@colName = 'room_capacity')
    BEGIN
    INSERT @returnTable
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.room_capacity, RoomTypes.room_bed, RoomTypes.room_price
            , RoomStatus.status_name
    FROM Rooms, RoomTypes, RoomStatus
    WHERE Rooms.room_type = RoomTypes.room_type_id 
    AND Rooms.room_status = RoomStatus.status_id
    AND room_capacity LIKE '%'+ @valueToFind + '%'
    RETURN
    END
    IF(@colName = 'room_bed')
    BEGIN
    INSERT @returnTable
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.room_capacity, RoomTypes.room_bed, RoomTypes.room_price
            , RoomStatus.status_name
    FROM Rooms, RoomTypes, RoomStatus
    WHERE Rooms.room_type = RoomTypes.room_type_id 
    AND Rooms.room_status = RoomStatus.status_id
    AND room_bed LIKE '%'+ @valueToFind + '%'
    RETURN
    END
    IF(@colName = 'room_price')
    BEGIN
    INSERT @returnTable
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.room_capacity, RoomTypes.room_bed, RoomTypes.room_price
            , RoomStatus.status_name
    FROM Rooms, RoomTypes, RoomStatus
    WHERE Rooms.room_type = RoomTypes.room_type_id 
    AND Rooms.room_status = RoomStatus.status_id
    AND room_price LIKE '%'+ @valueToFind + '%'
    RETURN
    END
    IF(@colName = 'room_status')
    BEGIN
    INSERT @returnTable
    SELECT Rooms.room_id, RoomTypes.type_name, RoomTypes.room_capacity, RoomTypes.room_bed, RoomTypes.room_price
            , RoomStatus.status_name
    FROM Rooms, RoomTypes, RoomStatus
    WHERE Rooms.room_type = RoomTypes.room_type_id 
    AND Rooms.room_status = RoomStatus.status_id
    AND room_status LIKE '%'+ @valueToFind + '%'
    RETURN
    END
    RETURN
END

/****************************/
CREATE FUNCTION [dbo].[Function_checkUsernameExisted]
(
	@username NVARCHAR(30)
)
RETURNS INTEGER
AS
BEGIN
	DECLARE @result INTEGER
	SET @result = (SELECT COUNT(*) FROM Customers WHERE dbo.Customers.username = @username)
	RETURN @result
END

/****************************/
CREATE FUNCTION Function_countBooking()
RETURNS INTEGER
AS 
BEGIN 
	DECLARE @count INTEGER
	SET @count = (Select Count(*) From Booking)
	RETURN @count
END;

/****************************/
CREATE FUNCTION Function_countCustomers()
RETURNS INTEGER
AS 
BEGIN 
	DECLARE @count INTEGER
	SET @count = (Select Count(*) From Customers)
	RETURN @count
END;

/****************************/
CREATE FUNCTION Function_getPriceRoom_byTypeId(
	@room_type_id INT
)
RETURNS DECIMAL(18)
AS 
BEGIN 
	DECLARE @price DECIMAL(18)
	SET @price = (SELECT RoomTypes.room_price FROM RoomTypes
					WHERE RoomTypes.room_type_id = @room_type_id)
	RETURN @price
END;

/****************************/
CREATE FUNCTION Function_getRoomtype_byRoomID
(
	@room_id INT
)
RETURNS INT
AS 
BEGIN 
	DECLARE @result INT
	SET @result = (SELECT room_type FROM Rooms
					WHERE room_id = @room_id)
	RETURN @result
END;

/****************************/
CREATE FUNCTION Function_LOGIN
(
	@username NVARCHAR(30),
	@password NVARCHAR(30)
)
RETURNS VARCHAR(20)
AS
BEGIN 
	DECLARE @match_count INTEGER, @result VARCHAR(20)
	SET @match_count = (SELECT COUNT(*)
						FROM Customers
						WHERE Customers.username = @username
						AND Customers.password = @password)
	
	IF @match_count = 0 
	BEGIN 
		SET @result = 'Wrong username or password';
	END

	ELSE
	BEGIN
		IF @match_count = 1
		BEGIN
			SET @result = 'Login successfull';
		END
		
		ELSE
		BEGIN
			SET @result = 'Too many matches, this should never happen before!';
		END		
	END;
	return @result
END;