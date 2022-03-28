﻿using Microsoft.Extensions.DependencyInjection;
using NetTopologySuite.IO.Converters;
using OgcApi.Net.Features;
using System;

namespace OgcApi.Net
{
    public static class OgcFeaturesApiMvcBuilderExtensions
    {
        public static IMvcBuilder AddOgcApiControllers(
            this IMvcBuilder mvcBuilder)
        {
            if (mvcBuilder == null) throw new ArgumentNullException(nameof(mvcBuilder));

            return mvcBuilder.AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new OgcGeoJsonConverterFactory());
                options.JsonSerializerOptions.Converters.Add(new GeoJsonConverterFactory());
            }).AddApplicationPart(typeof(OgcFeaturesApiMvcBuilderExtensions).Assembly);
        }
    }
}