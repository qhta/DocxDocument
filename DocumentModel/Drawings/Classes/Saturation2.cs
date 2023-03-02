namespace DocumentModel.Drawings;

/// <summary>
///   Defines the Saturation Class.
/// </summary>
public record Saturation2
{
  /// <summary>
  ///   sat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SaturationAmount { get; set; }
}