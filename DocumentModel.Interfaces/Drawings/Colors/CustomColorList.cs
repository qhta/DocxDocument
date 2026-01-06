namespace DocumentModel.Drawings;

/// <summary>
/// Defines a list of custom colors for drawing elements.
/// </summary>
public interface CustomColorList : IElementCollection<CustomColor>
{
  /// <summary>
  /// Extension list.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}