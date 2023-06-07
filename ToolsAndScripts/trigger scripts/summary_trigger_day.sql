delimiter //
CREATE TRIGGER sum_voice_day_01_after_insert
AFTER INSERT
   ON sum_voice_day_01 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_01
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_02_after_insert
AFTER INSERT
   ON sum_voice_day_02 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_02
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_03_after_insert
AFTER INSERT
   ON sum_voice_day_03 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_03
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_04_after_insert
AFTER INSERT
   ON sum_voice_day_04 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_04
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_05_after_insert
AFTER INSERT
   ON sum_voice_day_05 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_05
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_06_after_insert
AFTER INSERT
   ON sum_voice_day_06 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_06
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration;

END;//
delimiter ;



#update triggers

delimiter //
CREATE TRIGGER sum_voice_day_01_after_update
AFTER update
   ON sum_voice_day_01 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_01
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration-OLD.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_02_after_update
AFTER update
   ON sum_voice_day_02 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_02
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration-OLD.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_03_after_update
AFTER update
   ON sum_voice_day_03 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_03
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration-OLD.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_04_after_update
AFTER update
   ON sum_voice_day_04 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_04
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration-OLD.actualduration;

END;//
delimiter ;

delimiter //
CREATE TRIGGER sum_voice_day_05_after_update
AFTER update
   ON sum_voice_day_05 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_05
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration-OLD.actualduration;

END;//
delimiter ;


delimiter //
CREATE TRIGGER sum_voice_day_06_after_update
AFTER update
   ON sum_voice_day_06 FOR EACH ROW

BEGIN

   update cdrsummarymeta_day_06
   set totalInsertedDuration=totalInsertedDuration+NEW.actualduration-OLD.actualduration;

END;//
delimiter ;