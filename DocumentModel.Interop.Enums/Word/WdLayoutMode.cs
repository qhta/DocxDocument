namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how text is laid out in the layout mode for the current document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdlayoutmode?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLayoutMode
{
  /// <summary>
  /// Specifies how text is laid out in the layout mode for the current document.
  /// </summary>
  Default = 0,
  /// <summary>
  /// Specifies how text is laid out in the layout mode for the current document.
  /// </summary>
  Grid = 1,
  /// <summary>
  /// Specifies how text is laid out in the layout mode for the current document.
  /// </summary>
  LineGrid = 2,
  /// <summary>
  /// Specifies how text is laid out in the layout mode for the current document.
  /// </summary>
  Genko = 3
}
