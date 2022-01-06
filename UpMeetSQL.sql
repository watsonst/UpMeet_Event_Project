--Drop table if exists Events
Drop table if exists Favorites
--drop database UpMeet

Create database UpMeet

Create table Events(
EventId int primary key Identity(1,1),
Title nvarchar(255) not null,
Date smalldatetime not null,
Location nvarchar(255) not null,
Organization nvarchar(255) not null,
Details nvarchar(500) not null
)

insert into Events (Title, Date, Location, Organization, Details)
values 
('Nana Does Vegas', '2022-01-09T18:00:00','Meadow Brook Theatre','Nana', 'Nana Does Vegas 2022 tour is coming to Meadow Brook Theatre. On average, patrons can expect to pay $149.00 for Nana Does Vegas Rochester Hills tickets. Premium seats in the center orchestra can cost up to $299.00. Cheap Nana Does Vegas tickets are often available for seats in the balcony or mezzanine section of the theater. These seats often start as low as $73.00 a ticket. Use the Nana Does Vegas Meadow Brook Theatre seating chart to find tickets that match your budget.' ),
('Gilmore Girls Inspired Dinner', '2022-01-09T18:00:00','118 W. 3rd Street, Rochester, MI 48307','Tonias Victorian Rose Tea Room & More', '"Where you lead, I will follow." Join us for a holiday dinner celebrating our favorite Gilmore Family! This dinner and trivia will focus on the episode, "The Bracebridge Dinner," where Lorelai invites most of the citizens of Stars Hollow to an elaborate feast complete with horse-drawn carriage ride! In true Gilmore Girls Fashion, the menu will include: 1. Lukes Diner Appetizers 2. Sookie Worthy Entree 3. Rory Approved Dessert'),
('Mimosas and Music', '2022-01-17T09:00:00','13330 E 10 Mile Rd, Warren, MI','DAPPER DAVE| DETROIT CHOICE EVENTS| HORNITO TEQUILA', 'JOIN US FOR DETROIT FAVORITE BRUNCH.SOUL FOOD BRUNCH MENU + SOULFUL SOUNDS OF "ELEVEATE BAND" + SPECIAL GUEST -Bianca Barber aka B Natural. COMPLIMENTARY MIMOSAS + HORNITOS TEQUILA SPECIALS.$25 PER PERSON (BEFORE JAN 7) PROCEEDS TO BENEFIT 501C3 DAVES CHOICE DEVELOPMENT CORP. DAVESCHOICECDC.ORG'),
('Frolicking Frenchies Play Date', '2022-02-23T11:00:00','The Local Park','Stephanie Watson- Frenchie Lover', 'This group is an opportunity for Frenchies and their humans to get together for socialization and exercise. I imagine the Frenchies will be doing more exercising than the humans, but who knows? Cant wait to see you at the meet ups! Individuals who attempt to buy sell dogs through this meetup group will be blocked.If you are looking to find a new home for your dog, I recommend French Bulldog Rescue.'),
('Ukulele Club Online Jam', '2022-01-12T19:00:00','Online','Ukulele Club', 'Join us online via Zoom every second Wednesday of the month for a fun evening of strumming, starting with beginner-level songs (see Kids Book) to more challenging intermediate-level songs (see other 3 books). All levels are welcome! Looking forward to seeing old friends and meeting new ones!'),
('Cinema in the Street', '2022-1-10 15:00:00', '14 Mile and Main St.', 'DDA','Join us on South Main Street when the street closes for a downtown movie night. Games and entertainment from 6:30-9pm and the movie starts at dusk. Bring your blankets and lawn chairs and settle in for a great movie.The movie this year is Night at the Museum!'),
('Farmers Market', '2022-1-15 10:00:00', 'City Park', 'Parks and Recreation','The Clawson Farmers Market is your small neighborhood market tucked into the Clawson City Park, offering a lively gathering place for everyone, a diversity of local farm products, specialty foods and other assorted items. The friendly atmosphere and warm sunny days offer a late Sunday morning of shopping, enjoying the park, and listening to local musicians.'),
('Groundhog Day', '2022-2-2 09:00:00', 'Gobblers Knob', 'The Punxsutawney Groundhog Club','Groundhog Day is an experience of a lifetime. Maybe it is on your bucket list, or maybe it falls on your birthday or maybe you simply want to experience the Legend of Punxsutawney Phil. Whatever your reason Groundhog Day is an event and holiday for everyone!'),
('Free Concert', '2022-2-4 17:00:00', 'Doghouse Lounge', 'DIY Krew', 'Come see Calamity Disco with special guests Crunch Boot and Retail Yeti. Doors at 9. Drink specials.'),
('Chili Cook Off', '2022-1-28 14:00:00', 'Clawson United Methodist Church', 'Rotary Club', 'Join us for our Annual Soup and Chili Cook Off and enjoy some of the best homemade dishes in the world.  Our talented members bring their own special and very delicious recipes for all of our guests to try.  Afterwards we will have a dessert auction with the funds raised going to our general fund.');

Select * from Events

Create table Favorites(
ID int primary key Identity(1,1),
EventID int foreign key references Events(EventID),
UserID nvarchar(255) not null
);

insert into Favorites (EventID, UserID)
values 
('5', 'steph1')

Select * from Favorites