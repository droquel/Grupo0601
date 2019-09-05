using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Grupo0601
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, ILocationListener
    {

         TextView textCity, txtLastUpdate, txtDescription, txtHumidity, txtTime, txtCelsius;
            ImageView imgView;

        LocationManager locationManager;
        string providar;
        static double lat, lng;
        OpenMap openMap = new OpenMap();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
        }

        /*public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }*/

        /*public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }*/

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void onResume(){
        base.OnResume();
            locationManager.RequestLocationUpdate(provider, 400, 1, this);
        }

        protected override void OnPause()
        {
            base.OnPause();
            locationManager.RemoveUpdates(this);
        }

        public void onLocationChanged(Location location){
        lat = Math.Round(location.Latitude, 4);
            lng = Math.Round(location.Longitude, 4);
    }
    public void onProviderDisable(string provider){    
    }  
        
        private class GetWeather: AsyncTask<String, Java.Lang.Void, String>{
            private ProgressDialog pd = new ProgressDialog(Application.Context);
            private MainActivity activity;
            OpenMap openmap;

            public GetWeather(MainActivity activity, OpenMap openmap)
{
            this.activity = activity;
                this.openmap = openmap;
            }

            protected override void OnPreExecute()
            {
                base.OnPreExecute();
                pd.Window.SetType(Android.Views.WindowManagerTypes.SystemAlert);
                pd.SetTitle("Espere por favor ....");
                pd.Show();
            }

            protected override string RunInBackground(params string[] @params)
            {
                string stream = null;
                string urlString = @params[0];

                Solucion.solucion http = new Solucion.solucion();
                // urlString = Raiz.raiz.APIRequest(lat.ToString(), lng.ToString())
                stream = hhtp.GetHTTPData(urlString);
                return stream;
            }

            protected override void OnPostExecute(string result)
            {
                base.OnPostExecute(result);
                if(result.Contains("Error: lugar no encontrado. ")){
                    pd.Dismiss();
                    return;
}
                openmap = JsonConvert.
            }


        }                                                                           
	
        
    
}


}

