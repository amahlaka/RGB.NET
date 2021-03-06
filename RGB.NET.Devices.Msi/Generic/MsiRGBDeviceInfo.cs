﻿using System;
using RGB.NET.Core;

namespace RGB.NET.Devices.Msi
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a generic information for a Corsair-<see cref="T:RGB.NET.Core.IRGBDevice" />.
    /// </summary>
    public class MsiRGBDeviceInfo : IRGBDeviceInfo
    {
        #region Properties & Fields

        /// <inheritdoc />
        public RGBDeviceType DeviceType { get; }

        /// <summary>
        /// Gets the internal type of the <see cref="IRGBDevice"/>.
        /// </summary>
        public string MsiDeviceType { get; }

        /// <inheritdoc />
        public string Manufacturer { get; }

        /// <inheritdoc />
        public string Model { get; }

        /// <inheritdoc />
        public Uri Image { get; set; }

        /// <inheritdoc />
        public bool SupportsSyncBack => false;

        /// <inheritdoc />
        public RGBDeviceLighting Lighting => RGBDeviceLighting.Key;

        #endregion

        #region Constructors

        /// <summary>
        /// Internal constructor of managed <see cref="MsiRGBDeviceInfo"/>.
        /// </summary>
        /// <param name="deviceType">The type of the <see cref="IRGBDevice"/>.</param>
        /// <param name="msiDeviceType">The internal type of the <see cref="IRGBDevice"/>.</param>
        /// <param name="manufacturer">The manufacturer-name of the <see cref="IRGBDevice"/>.</param>
        /// <param name="model">The model-name of the <see cref="IRGBDevice"/>.</param>
        internal MsiRGBDeviceInfo(RGBDeviceType deviceType, string msiDeviceType, string manufacturer = "Msi", string model = "Generic Msi-Device")
        {
            this.DeviceType = deviceType;
            this.MsiDeviceType = msiDeviceType;
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        #endregion
    }
}
