namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the OfficeStyleSheetExtension Class.
/// </summary>
public class OfficeStyleSheetExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public ThemeFamily? ThemeFamily { get; set; }
}
