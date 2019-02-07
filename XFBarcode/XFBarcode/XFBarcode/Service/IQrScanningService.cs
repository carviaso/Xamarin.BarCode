using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.App.BarCodeTest.Service
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
