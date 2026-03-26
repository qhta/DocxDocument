namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ViewValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ViewValues))]
public enum ViewType
{
  /// <summary>
  /// A normal view.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ViewValues.Normal))]
  NormalView = 1,

  /// <summary>
  /// An outline view.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ViewValues.Outline))]
  OutlineView = 2,

  /// <summary>
  /// A print view.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ViewValues.Print))]
  PrintView = 3,

  /// <summary>
  /// A print preview view.
  /// </summary>
  //[OpenXmlEnumValue(nameof(DXW.ViewValues.PrintPreview))]
  PrintPreview = 4,

  /// <summary>
  /// A master view.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ViewValues.MasterPages))]
  MasterView = 5,

  /// <summary>
  /// A Web view.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ViewValues.Web))]
  WebView = 6,

  /// <summary>
  /// A reading view.
  /// </summary>
  ReadingView = 7,

  /// <summary>
  /// No description is available.
  /// </summary>
  ConflictView = 8,
}