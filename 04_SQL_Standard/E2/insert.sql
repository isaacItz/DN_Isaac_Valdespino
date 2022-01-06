INSERT INTO `city` VALUES (0,'CDMX');
INSERT INTO `city` VALUES (1,'Aguascalientes');
INSERT INTO `city` VALUES (2,'Zitacuaro');
INSERT INTO `city` VALUES (3,'Jungapeo');
INSERT INTO `city` VALUES (4,'Tuxpan');

--
-- Dumping data for table `equipmenttype`
--

INSERT INTO `equipmenttype` VALUES (0,'barbels','The barbell bar is one of the most basic pieces of equipment for any gym. You can find several different varieties of barbell bar, some pretty unusual looking for specialized training. There isn’t a muscle you can’t train with it.');
INSERT INTO `equipmenttype` VALUES (1,'dumbbells','The barbell bar is one of the most basic pieces of equipment for any gym. You can find several different varieties of barbell bar, some pretty unusual looking for specialized training. There isn’t a muscle you can’t train with it.');
INSERT INTO `equipmenttype` VALUES (2,'E-Z Bar','The E-Z bar is a standard barbell bar bent at around shoulder width grip. The E-Z bar is much better for biceps curls than the standard barbell because it puts your wrists in a more natural grip position. I have injured my wrists about two decades ago from doing biceps curls with barbells. Never again. Always E-Z bar for me.');
INSERT INTO `equipmenttype` VALUES (3,'Resistance Bands','Resistance bands are lengths of elastic tubing with a handle on each end and simulate weighted resistance to exercise the muscles. Resistance bands can be used to train all the same muscles as dumbbells and barbells.');
INSERT INTO `equipmenttype` VALUES (4,'Bench Press Machine','This is the number one exercise for chest, and definitely the most famous one. This is the exercise by which many people measure their overall strength. Ever heard someone say: How much you bench?');

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` VALUES (0,5,5,'2026-01-27',50.00,0);
INSERT INTO `inventory` VALUES (1,5,3,'2026-01-27',50.00,0);
INSERT INTO `inventory` VALUES (2,5,5,'2026-01-27',56.00,4);
INSERT INTO `inventory` VALUES (3,7,5,'2026-01-27',55.00,4);
INSERT INTO `inventory` VALUES (4,5,4,'2023-01-27',70.00,1);

--
-- Dumping data for table `measuretype`
--

INSERT INTO `measuretype` VALUES (0,'grams');
INSERT INTO `measuretype` VALUES (1,'kilogram');
INSERT INTO `measuretype` VALUES (2,'pound');
INSERT INTO `measuretype` VALUES (3,'milliliter');
INSERT INTO `measuretype` VALUES (4,'liter');

--
-- Dumping data for table `member`
--

INSERT INTO `member` VALUES (0,'bob','rodriguez','1999-01-01','bob@constructor.com',1,1);
INSERT INTO `member` VALUES (1,'serch','martinez','1999-01-01','serch@serch.serch',0,1);
INSERT INTO `member` VALUES (2,'mark','antony','1998-04-07','marc@antonio.com',0,1);
INSERT INTO `member` VALUES (3,'drak','spartan','1970-06-09','drak@spartangeek.com',1,1);
INSERT INTO `member` VALUES (4,'mario','bros','1983-01-01','bros@brothers.com',0,1);

--
-- Dumping data for table `membermembership`
--

INSERT INTO `membermembership` VALUES (0,'2022-01-05',0,0,1);
INSERT INTO `membermembership` VALUES (1,'2022-01-05',1,1,1);
INSERT INTO `membermembership` VALUES (2,'2022-01-05',2,2,1);
INSERT INTO `membermembership` VALUES (3,'2022-01-05',3,3,1);
INSERT INTO `membermembership` VALUES (4,'2022-01-05',4,4,1);

--
-- Dumping data for table `membershiptype`
--

INSERT INTO `membershiptype` VALUES (0,'Basic',5.00,'2022-01-05',30,'day');
INSERT INTO `membershiptype` VALUES (1,'Pro',20.00,'2022-01-05',2,'month');
INSERT INTO `membershiptype` VALUES (2,'Plus',60.00,'2022-01-05',6,'month');
INSERT INTO `membershiptype` VALUES (3,'Max',100.00,'2022-01-05',1,'year');
INSERT INTO `membershiptype` VALUES (4,'Xtreme!',5000.00,'2022-01-05',10,'year');

--
-- Dumping data for table `product`
--

INSERT INTO `product` VALUES (0,'Mass Gainer','Meta Nutrition',1.00,1,0);
INSERT INTO `product` VALUES (1,'Total ISO','Cutler Nutrition',1.00,1,0);
INSERT INTO `product` VALUES (2,'Iron Mass','Arnold Schwarzenegger',1.00,1,0);
INSERT INTO `product` VALUES (3,'Pump-XS','RC',1.00,1,0);
INSERT INTO `product` VALUES (4,'Yeah Buddy','RC',1.00,1,5);

--
-- Dumping data for table `producttype`
--

INSERT INTO `producttype` VALUES (0,'Protein');
INSERT INTO `producttype` VALUES (1,'Creatin');
INSERT INTO `producttype` VALUES (2,'Amino Acids');
INSERT INTO `producttype` VALUES (3,'Towel');
INSERT INTO `producttype` VALUES (4,'Testosterone');
INSERT INTO `producttype` VALUES (5,'pre-workout');

--
-- Dumping data for table `role`
--

INSERT INTO `role` VALUES (0,'Sales Manager');
INSERT INTO `role` VALUES (1,'Operations Manager');
INSERT INTO `role` VALUES (2,'Fitness Instructors');
INSERT INTO `role` VALUES (3,'Personal Trainers');
INSERT INTO `role` VALUES (4,'Maintenance Personnel');

--
-- Dumping data for table `sale`
--

INSERT INTO `sale` VALUES (0,'2022-01-05 00:00:00',55.00);
INSERT INTO `sale` VALUES (1,'2022-01-05 00:00:00',55.00);
INSERT INTO `sale` VALUES (2,'2022-01-05 00:00:00',50.00);
INSERT INTO `sale` VALUES (3,'2022-01-05 00:00:00',50.00);
INSERT INTO `sale` VALUES (4,'2022-01-05 00:00:00',70.00);

--
-- Dumping data for table `sale_row`
--

INSERT INTO `sale_row` VALUES (0,4,1,0);
INSERT INTO `sale_row` VALUES (1,4,1,1);
INSERT INTO `sale_row` VALUES (2,0,1,2);
INSERT INTO `sale_row` VALUES (3,0,1,3);
INSERT INTO `sale_row` VALUES (4,1,1,4);

--
-- Dumping data for table `user`
--

INSERT INTO `user` VALUES (0,'the_master88','password','master@gmail.com','Robert','Musk',0);
INSERT INTO `user` VALUES (1,'invincible','pass1234','invin@cible.com','James','Rodriguez',0);
INSERT INTO `user` VALUES (2,'Canels','imthechampion','can@nelo.com','Saul','Alvarez',0);
INSERT INTO `user` VALUES (3,'kimdotcom','thecrack','imKim@dot.com','Kim','dotcom',0);
INSERT INTO `user` VALUES (4,'Elon','musk','elon@musk.com','Elon','Musk',0);

--
-- Dumping data for table `userinrole`
--

INSERT INTO `userinrole` VALUES (3,1,'2022-01-05');
INSERT INTO `userinrole` VALUES (1,0,'2022-01-05');
INSERT INTO `userinrole` VALUES (0,2,'2022-01-05');
INSERT INTO `userinrole` VALUES (2,3,'2022-01-05');
INSERT INTO `userinrole` VALUES (4,4,'2022-01-05');
