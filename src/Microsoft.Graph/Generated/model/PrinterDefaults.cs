// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type PrinterDefaults.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PrinterDefaults
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterDefaults"/> class.
        /// </summary>
        public PrinterDefaults()
        {
            this.ODataType = "microsoft.graph.printerDefaults";
        }

        /// <summary>
        /// Gets or sets colorMode.
        /// The default color mode to use when printing the document. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "colorMode", Required = Newtonsoft.Json.Required.Default)]
        public PrintColorMode? ColorMode { get; set; }
    
        /// <summary>
        /// Gets or sets contentType.
        /// The default content (MIME) type to use when processing documents.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentType", Required = Newtonsoft.Json.Required.Default)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets copiesPerJob.
        /// The default number of copies printed per job.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "copiesPerJob", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CopiesPerJob { get; set; }
    
        /// <summary>
        /// Gets or sets dpi.
        /// The default resolution in DPI to use when printing the job.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dpi", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Dpi { get; set; }
    
        /// <summary>
        /// Gets or sets duplexMode.
        /// The default duplex (double-sided) configuration to use when printing a document. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duplexMode", Required = Newtonsoft.Json.Required.Default)]
        public PrintDuplexMode? DuplexMode { get; set; }
    
        /// <summary>
        /// Gets or sets finishings.
        /// The default set of finishings to apply to print jobs. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "finishings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintFinishing> Finishings { get; set; }
    
        /// <summary>
        /// Gets or sets fitPdfToPage.
        /// The default fitPdfToPage setting. True to fit each page of a PDF document to a physical sheet of media; false to let the printer decide how to lay out impressions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fitPdfToPage", Required = Newtonsoft.Json.Required.Default)]
        public bool? FitPdfToPage { get; set; }
    
        /// <summary>
        /// Gets or sets inputBin.
        /// The default input bin that serves as the paper source.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inputBin", Required = Newtonsoft.Json.Required.Default)]
        public string InputBin { get; set; }
    
        /// <summary>
        /// Gets or sets mediaColor.
        /// The default media (such as paper) color to print the document on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaColor", Required = Newtonsoft.Json.Required.Default)]
        public string MediaColor { get; set; }
    
        /// <summary>
        /// Gets or sets mediaSize.
        /// The default media size to use. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaSize", Required = Newtonsoft.Json.Required.Default)]
        public string MediaSize { get; set; }
    
        /// <summary>
        /// Gets or sets mediaType.
        /// The default media (such as paper) type to print the document on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaType", Required = Newtonsoft.Json.Required.Default)]
        public string MediaType { get; set; }
    
        /// <summary>
        /// Gets or sets multipageLayout.
        /// The default direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multipageLayout", Required = Newtonsoft.Json.Required.Default)]
        public PrintMultipageLayout? MultipageLayout { get; set; }
    
        /// <summary>
        /// Gets or sets orientation.
        /// The default orientation to use when printing the document. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orientation", Required = Newtonsoft.Json.Required.Default)]
        public PrintOrientation? Orientation { get; set; }
    
        /// <summary>
        /// Gets or sets outputBin.
        /// The default output bin to place completed prints into. See the printer's capabilities for a list of supported output bins.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outputBin", Required = Newtonsoft.Json.Required.Default)]
        public string OutputBin { get; set; }
    
        /// <summary>
        /// Gets or sets pagesPerSheet.
        /// The default number of document pages to print on each sheet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pagesPerSheet", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PagesPerSheet { get; set; }
    
        /// <summary>
        /// Gets or sets quality.
        /// The default quality to use when printing the document. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "quality", Required = Newtonsoft.Json.Required.Default)]
        public PrintQuality? Quality { get; set; }
    
        /// <summary>
        /// Gets or sets scaling.
        /// Specifies how the printer scales the document data to fit the requested media. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scaling", Required = Newtonsoft.Json.Required.Default)]
        public PrintScaling? Scaling { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
