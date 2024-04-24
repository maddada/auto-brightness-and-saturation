namespace auto_brightness_and_vibrance.GPU
{
    internal interface IGPU
    {
        GPUVendor Vendor { get; }
        int Saturation { get; set; }
        int MaxSaturation { get; }
        int MinSaturation { get; }
        int InitSaturation { get; }
        void ResetSaturation();
        void Load(string display);
        void Close();
    }
}
