using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace BoardCastTest
{
   public class MyService : Service
    {
        public override IBinder OnBind(Intent intent)
        {
            Log.Debug("Mike", "DemoService OnBind");
            Toast.MakeText(this, "OnBind", ToastLength.Long).Show();
            return new MyServiceBinder(this);
        }
        public override StartCommandResult OnStartCommand(Android.Content.Intent intent, StartCommandFlags flags, int startId)
        {
            // This method executes on the main thread of the application.
            Log.Debug("Mike", "DemoService started");
            Toast.MakeText(this, "StartCommandResult", ToastLength.Long).Show();
            return StartCommandResult.Sticky;
        }
    }
    public class MyServiceBinder : Binder
    {
        public MyServiceBinder(MyService service)
        {
            this.Service = service;
        }

        public MyService Service { get; private set; }
    }
}