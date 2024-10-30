using System;
using Solid_Principles.classes;

INotification emailNotification = new EmailNotification();
INotification smsNotification = new SMSNotification();

NotificationService notificationServiceEmail = new NotificationService(emailNotification);
NotificationService notificationServiceSMS = new NotificationService(smsNotification);

notificationServiceEmail.Notify("Hello via Email!");
notificationServiceSMS.Notify("Hello via SMS!");

public interface INotification
{
    void Send(string message);
}




