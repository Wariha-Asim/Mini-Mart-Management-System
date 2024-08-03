create database minimart
use minimart
  create table logininfo(
    id INT PRIMARY KEY IDENTITY(1,1),
    email VARCHAR(100) unique,
    password VARCHAR(50)
);

create table customerlogininfo(
    id INT PRIMARY KEY IDENTITY(1,1),
    email VARCHAR(100),
    password VARCHAR(50)
);
insert into logininfo('minimart','789');
insert into customerlogininfo values ('customerofmart','123');
CREATE TABLE Cart (
    cart_id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT FOREIGN KEY REFERENCES customerlogininfo(id),
    product_id INT FOREIGN KEY REFERENCES product(pid),
    quantity INT,
    added_date DATETIME DEFAULT GETDATE()
);
create table product(pid int primary key identity(201,1),
pname varchar(50),
pprice int check(pprice>0),
pquantity int not null,
pcategory int foreign key references category(id));
drop table product
select * from category;
create table category(
id int primary key identity(101,1),
categoryname varchar(50),
);
insert into category values('Food'),('Medicine'),('Clothing'),('Accessories'),('Stationary');
INSERT INTO product (pname, pprice, pquantity, pcategory) VALUES 
('Lays Potato Chips', 50, 200, 101),
('Nestle Nido Milk Powder', 1200, 150, 101),
('Shan Biryani Masala', 150, 180, 101),
('National Foods Chilli Sauce', 80, 220, 101),
('Quaker Oats', 350, 100, 101),
('Pepsi', 60, 250, 101),
('Tetra Pak Milk', 70, 180, 101),
('Dalda Banaspati', 180, 200, 101),
('Rafhan Custard Powder', 90, 150, 101),
('Knorr Chicken Cubes', 100, 120, 101),
('Shan Haleem Masala', 200, 100, 101),
('Brooke Bond Supreme Tea', 250, 180, 101),
('National Foods Chat Masala', 70, 150, 101),
('Nestle Cerelac', 350, 120, 101),
('Sprite', 50, 200, 101),
('Mitchells Tomato Ketchup', 120, 180, 101),
('Shan Chaat Masala', 80, 200, 101),
('Nurpur Milk', 60, 220, 101),
('National Foods Ginger Paste', 100, 150, 101),
('Shan Chicken Tikka Masala', 200, 120, 101),
('Rafhan Jelly', 150, 100, 101),
('National Foods Mango Pickle', 120, 150, 101),
('Shan Korma Masala', 180, 180, 101),
('Olpers Cream', 250, 100, 101),
('Mitchells Fruit Cocktail', 80, 200, 101),
('Pepsi 2.25L Bottle', 100, 180, 101),
('Shan Nihari Masala', 200, 150, 101),
('Nestle Fruit Yogurt', 50, 220, 101),
('National Foods Mango Chatni', 120, 120, 101), 
('Hamdard Roghan Badam Shirin', 300, 100, 102),
('Strepsils', 150, 150, 102),
('Savlon Antiseptic Liquid', 200, 120, 102),
('Savlon Hand Wash', 120, 180, 102),
('Savlon Soap', 50, 200, 102),
('Tiger Balm', 100, 150, 102),
('Calpol', 120, 100, 102),
('Dettol Antiseptic Liquid', 200, 180, 102),
('Dettol Hand Sanitizer', 150, 120, 102),
('Dettol Soap', 50, 150, 102),
('Himalaya Toothpaste', 100, 100, 102),
('Himalaya Shampoo', 200, 180, 102),
('Himalaya Purifying Neem Face Wash', 150, 120, 102),
('Himalaya Diaper Rash Cream', 300, 100, 102), 
('Bonanza Satrangi', 3500, 200, 103),
('J. Two Piece', 3200, 150, 103),
('Limelight', 2800, 180, 103),
('Gul Ahmed Unstitched Lawn', 4000, 220, 103),
('Khaadi Lawn', 4500, 150, 103),
('Nishat Linen', 3000, 180, 103),
('Alkaram Studio Lawn', 2800, 200, 103),('Sana Safinaz Muzlin Collection', 4200, 150, 103),
('Ethnic by Outfitters', 3500, 180, 103),
('Limelight Pret', 2500, 200, 103),
('Junaid Jamshed Pret', 3000, 150, 103),
('Gul Ahmed Stitched', 4500, 180, 103),
('Chinyere', 4000, 220, 103),
('Nishat Linen Pret', 3500, 150, 103),
('Khaadi Pret', 3800, 180, 103),
('Sapphire Unstitched', 5000, 200, 103),
('Baroque', 4200, 150, 103),
('Gul Ahmed Pret', 4500, 180, 103),
('Alkaram Studio Pret', 3200, 200, 103),
('Asim Jofa', 5500, 150, 103),
('J.', 1500, 200, 104),
('Charcoal Shoes', 2500, 150, 104),
('Gul Ahmed Shoes', 2800, 180, 104),
('Junaid Jamshed Shoes', 3000, 220, 104),
('Borjan', 2000, 150, 104),
('Stylo', 1800, 180, 104),
('Insignia', 2200, 200, 104),
('Bata', 2500, 150, 104),
('Service', 1900, 180, 104),
('Hush Puppies', 3200, 200, 104),
('Unze London', 2800, 150, 104),
('Metro Shoes', 3500, 180, 104),
('ECS', 2000, 200, 104),
('Urban Sole', 1800, 150, 104),('Bata', 1800, 150, 104),
('Service', 2200, 180, 104),
('Hush Puppies', 2500, 200, 104),
('Unze London', 1900, 150, 104),
('Metro Shoes', 3200, 180, 104),
('LOréal Paris', 2000, 200, 105),
('Gul Ahmed Perfume', 2500, 150, 105),
('J. Perfume', 2800, 180, 105),
('Khaadi Perfume', 3000, 220, 105),
('Junaid Jamshed Perfume', 1800, 150, 105),
('Sana Safinaz Perfume', 2200, 180, 105),
('Al Haramain', 3200, 200, 105),
('Ajmal Perfumes', 2800, 150, 105),
('Armaf', 3500, 180, 105),
('Nishane', 2500, 200, 105),
('Tom Ford', 1800, 150,105),('Hermes', 3200, 200, 105), ('Jo Malone', 2800, 150, 105), ('Burberry', 3500, 180, 105), 
('Ralph Lauren', 2500, 200, 105), ('Estee Lauder', 1800, 150, 105), ('Issey Miyake', 2200, 180, 105), ('Davidoff', 3000, 200, 105),
('Givenchy', 3200, 150, 105), ('Mont Blanc', 2800, 180, 105), ('Elizabeth Arden', 3500, 200, 105), ('Marc Jacobs', 2500, 150, 105), 
('Clinique', 1800, 180, 105), ('DKNY', 2200, 200, 105), ('Boucheron', 3000, 150, 105), ('Thierry Mugler', 3200, 180, 105), 
('Zara', 2800, 200, 105), ('Bvlgari', 3500, 150, 105), ('Guerlain', 2500, 180, 105), ('Hugo Boss', 1800, 200, 105);
);
create procedure categoryview
@i int
as
begin
select* from product where  pcategory=@i
end
exec categoryview 101;
CREATE PROCEDURE UpdateCartItemQuantity
    @customer_id INT,
    @product_id INT,
    @quantity INT
AS
BEGIN
    UPDATE Cart
    SET quantity = @quantity
    WHERE customer_id = @customer_id AND product_id = @product_id;
END;
CREATE PROCEDURE AddToCart
    @customer_id INT,
    @product_id INT,
    @quantity INT
AS
BEGIN
    DECLARE @existingQuantity INT;
    
    -- Check if the item already exists in the cart for the customer
    SELECT @existingQuantity = quantity
    FROM Cart
    WHERE customer_id = @customer_id AND product_id = @product_id;

    IF @existingQuantity IS NOT NULL
    BEGIN
        -- If the item exists, update the quantity
        UPDATE Cart
        SET quantity = @existingQuantity + @quantity
        WHERE customer_id = @customer_id AND product_id = @product_id;
    END
    ELSE
    BEGIN
        -- If the item does not exist, insert a new row
        INSERT INTO Cart (customer_id, product_id, quantity)
        VALUES (@customer_id, @product_id, @quantity);
    END
END;


CREATE PROCEDURE GetCartItems
    @customer_id INT
AS
BEGIN
    SELECT 
	p.pid ,
        p.pname,
        p.pprice,
        c.quantity,
        (p.pprice * c.quantity) AS total_price
    FROM Cart c
    JOIN product p ON c.product_id = p.pid
    WHERE c.customer_id = @customer_id;
END;


CREATE PROCEDURE RemoveFromCart
    @customer_id INT,
    @product_id varchar(50)
AS
BEGIN
    DELETE FROM Cart
    WHERE customer_id = @customer_id AND product_id = @product_id;
END;

exec RemoveFromCart 1, 204;
CREATE PROCEDURE ClearCart
    @customer_id INT
AS
BEGIN
    DELETE FROM cart
    WHERE customer_id = @customer_id;
END
select * from cart

create table log(
status1 varchar(50),
operation varchar(50)
);
create trigger cartmauwali on cart
after insert 
As
begin
insert into log values('Successfull','Insert');
end
select* from log
INSERT INTO logininfo values('mart','123');
select * from cart;
