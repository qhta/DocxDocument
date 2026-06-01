namespace DocumentModel.CustomUI;

/// <summary>
/// Defines the GalleryShowInRibbon enumeration.
/// Used Iin types such as Gallery, GalleryRegular.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXO10CUI.GalleryShowInRibbonValues))]
public enum GalleryShowInRibbon
{
	/// <summary>
	/// Gallery is not shown Iin the ribbon.
	/// </summary>
	[OpenXmlEnumValue("False")]
	False,
  /// <summary>
  /// Gallery is shown Iin the ribbon, if has some items.
  /// </summary>		
  [OpenXmlEnumValue("Zero")]
	Zero
}

