namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ColorTemperature Class.
/// </summary>
public class ColorTemperature: ModelElement
{
  /// <summary>
  ///   colorTemp, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? ColorTemperatureValue { get; set; }
}