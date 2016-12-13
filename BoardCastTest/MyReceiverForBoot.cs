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

namespace BoardCastTest
{
    [BroadcastReceiver]
    [IntentFilter(new[] {Intent.ActionBootCompleted})]
    public class MyReceiverForBoot : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            //Toast.MakeText(context, "Received intent!", ToastLength.Short).Show();
            Console.WriteLine("Hello Boot complete");
            Intent myserviceIntent = new Intent(context, typeof(MyService));
            context.StartService(myserviceIntent);
        }
    }
}