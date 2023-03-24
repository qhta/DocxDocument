namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the OfficeStyleSheetExtension Class.
/// </summary>
public class OfficeStyleSheetExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public ThemeFamily? ThemeFamily { get; set; }
}