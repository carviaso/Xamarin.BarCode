using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using XFBarcode.Services;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(XFBarcode.Droid.Services.QrScanningService))]
namespace XFBarcode.Droid.Services
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionDefault = new MobileBarcodeScanningOptions();
            var optionCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Acerca la Camara al elemento",
                BottomText = "Toca la pantalla para enfocar",
            };

            var scanResult = await scanner.Scan(optionCustom);
            return scanResult.Text;
        }
    }
}