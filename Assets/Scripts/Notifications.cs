using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class Notifications : MonoBehaviour
{
    void Start()
    {
        var channel = new AndroidNotificationChannel()
        {
            Id = "deafult_channel",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };

        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        var notification = new AndroidNotification();
        notification.Title = "Hey! Come back!";
        notification.Text = "Fast cars are waiting for you!";
        notification.FireTime = System.DateTime.Now.AddSeconds(10);

        AndroidNotificationCenter.SendNotification(notification, "deafult_channel");
    }
}
