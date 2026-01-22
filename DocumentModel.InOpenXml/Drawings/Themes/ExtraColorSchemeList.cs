namespace DocumentModel.Drawings;

/// <summary>
///   Represents a collection of extra color schemes for use in document themes.
/// </summary>
public class ExtraColorSchemeList: ModelElementCollection<ExtraColorScheme, DXD.ExtraColorSchemeList, DXD.ExtraColorScheme>,
  IExtendableElement
{
  /// <summary>
  /// List of extensions associated with the extra color scheme list.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}