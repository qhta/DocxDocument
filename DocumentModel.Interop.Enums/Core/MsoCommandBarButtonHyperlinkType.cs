namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether the command bar button is a hyperlink. If the command bar button is a hyperlink, further
/// specifies whether the hyperlink should launch another application such as the browser or insert a picture at
/// the active selection point.
/// </summary>
public enum MsoCommandBarButtonHyperlinkType
{
  /// <summary>
  /// Specifies whether the command bar button is a hyperlink. If the command bar button is a hyperlink, further
  /// specifies whether the hyperlink should launch another application such as the browser or insert a picture at
  /// the active selection point.
  /// </summary>
  None,
  /// <summary>
  /// Specifies whether the command bar button is a hyperlink. If the command bar button is a hyperlink, further
  /// specifies whether the hyperlink should launch another application such as the browser or insert a picture at
  /// the active selection point.
  /// </summary>
  Open,
  /// <summary>
  /// Specifies whether the command bar button is a hyperlink. If the command bar button is a hyperlink, further
  /// specifies whether the hyperlink should launch another application such as the browser or insert a picture at
  /// the active selection point.
  /// </summary>
  InsertPicture
}
