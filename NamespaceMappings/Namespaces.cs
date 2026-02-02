using Qhta.Collections;

namespace NamespaceMappings;

/// <summary>
/// Provides mappings between Open XML namespace URIs and their corresponding shortcut codes for use in document
/// processing or serialization scenarios.
/// </summary>
/// <remarks>The Namespaces class exposes two dictionaries: Map, which maps full Open XML namespace URIs
/// to their shortcut codes, and Namespaces, which maps shortcut codes back to their full namespace URIs. These mappings
/// can be used to simplify namespace handling when working with Open XML documents, such as when generating or parsing
/// XML with prefixed namespaces.</remarks>
public static class Namespaces
{

  /// <summary>
  /// Provides a mapping of fully qualified Open XML namespace names to their corresponding shortcut strings.
  /// </summary>
  /// <remarks>This dictionary can be used to look up standardized abbreviations for various Open XML
  /// namespaces, which may be useful for display, serialization, or code generation scenarios. The mapping is static
  /// and read-only; modifying the dictionary at runtime is not recommended.</remarks>
  public static readonly BiDiDictionary<string, string> Map = new()
  {
    { "DocumentFormat.OpenXml", "DX" },
    { "DocumentFormat.OpenXml.Bibliography", "DXB" },
    { "DocumentFormat.OpenXml.CustomProperties", "DXCP" },
    { "DocumentFormat.OpenXml.CustomXmlSchemaReferences", "DXCXSR" },
    { "DocumentFormat.OpenXml.Drawing", "DXD" },
    { "DocumentFormat.OpenXml.Drawing.Charts", "DXDC"},
    { "DocumentFormat.OpenXml.Drawing.Diagrams", "DXDD" },
    { "DocumentFormat.OpenXml.Drawing.Pictures", "DXDP" },
    { "DocumentFormat.OpenXml.Drawing.Spreadsheet", "DXDS" },
    { "DocumentFormat.OpenXml.Drawing.Wordprocessing", "DXDW" },
    { "DocumentFormat.OpenXml.ExtendedProperties", "DXEP" },
    { "DocumentFormat.OpenXml.Math", "DXM" },
    { "DocumentFormat.OpenXml.Office.Drawing", "DXOD" },
    { "DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed", "DXODY21OE" },
    { "DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink", "DXOY21SL" },
    { "DocumentFormat.OpenXml.Office.Word", "DXOW" },
    { "DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed", "DXOWY20OE" },
    { "DocumentFormat.OpenXml.Office2010.Drawing", "DXO10D" },
    { "DocumentFormat.OpenXml.Office2010.Drawing.Pictures", "DXO10DP" },
    { "DocumentFormat.OpenXml.Office2010.Word", "DXO10W" },
    { "DocumentFormat.OpenXml.Office2010.Word.Drawing", "DXO10WD" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas", "DXO10WDC" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingGroup", "DXO10WDG" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingShape", "DXO10WDS" },
    { "DocumentFormat.OpenXml.Office2013.Drawing", "DXO13D" },
    { "DocumentFormat.OpenXml.Office2013.Theme", "DXO13T" },
    { "DocumentFormat.OpenXml.Office2013.Word", "DXO13W" },
    { "DocumentFormat.OpenXml.Office2013.Word.Drawing", "DXO13WD" },
    { "DocumentFormat.OpenXml.Office2016.Drawing", "DXO16D" },
    { "DocumentFormat.OpenXml.Office2019.Drawing", "DXO19D" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor", "DXO19DHC" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.SVG", "DXO19DS" },
    { "DocumentFormat.OpenXml.Office2019.Presentation", "DXO19P" },
    { "DocumentFormat.OpenXml.Office2019.Word.Cid", "DXO19WC" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification", "DXO21DDC" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.Livefeed", "DXO21DL" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes", "DXO21DSS" },
    { "DocumentFormat.OpenXml.Office2021.MipLabelMetaData", "DXO21MLMD" },
    { "DocumentFormat.OpenXml.Office2021.Word.CommentsExt", "DXO21WCE" },
    { "DocumentFormat.OpenXml.Packaging", "DXPP" },
    { "DocumentFormat.OpenXml.Presentation", "DXP" },
    { "DocumentFormat.OpenXml.VariantTypes", "DXVT" },
    { "DocumentFormat.OpenXml.Vml", "DXV" },
    { "DocumentFormat.OpenXml.Vml.Office", "DXVO" },
    { "DocumentFormat.OpenXml.Vml.Spreadsheet", "DXVS" },
    { "DocumentFormat.OpenXml.Vml.Wordprocessing", "DXVW" },
    { "DocumentFormat.OpenXml.Wordprocessing", "DXW" },
  };
}
