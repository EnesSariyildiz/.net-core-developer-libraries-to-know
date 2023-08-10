using Solid.App.LSPGood;

BasePhone phone = new IPhone();

phone.Call();
((ITakePhoto)phone).TakePhoto();

phone = new Nokia3310();

phone.Call();




