using PiTop;
using PiTopMakerArchitecture.Foundation;
using PiTopMakerArchitecture.Foundation.Components;

namespace PiTopLightServer
{
    public class LEDService
    {
        PiTopModule _module;
        FoundationPlate _plate;
        private Led _green;
        private Led _amber;
        private Led _red;

        public LEDService()
        {
            _module = new PiTopModule();

            _plate = _module.GetOrCreatePlate<FoundationPlate>();

            _green = _plate.GetOrCreateDevice<Led>(DigitalPort.D0);
            _green.DisplayProperties.Add(new NamedCssColor("green"));

            _amber = _plate.GetOrCreateDevice<Led>(DigitalPort.D1);
            _amber.DisplayProperties.Add(new NamedCssColor("gold"));

            _red = _plate.GetOrCreateDevice<Led>(DigitalPort.D2);
            _red.DisplayProperties.Add(new NamedCssColor("red"));

            _green.Off();
            _amber.Off();
            _red.Off();
        }

        private void Toggle(Led led)
        {
            if(led.IsOn)
            {
                led.Off();
            }
            else
            {
                led.On();
            }
        }

        public void ToggleRed()
        {
            Toggle(_red);
        }

        public void ToggleGreen()
        {
            Toggle(_green);
        }

        public void ToggleGold()
        {
            Toggle(_amber);
        }
    }
}