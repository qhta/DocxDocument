namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Saturation Class.
/// </summary>
public class Saturation2: ModelElement
{
  /// <summary>
  ///   sat, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SaturationAmount { get; set; }
}