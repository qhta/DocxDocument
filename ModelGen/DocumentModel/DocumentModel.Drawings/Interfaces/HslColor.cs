namespace DocumentModel.Drawings;

/// <summary>
/// Hue, Saturation, Luminance Color Model.
/// </summary>
public interface HslColor // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? HueValue { get ; set; }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public Int32? SatValue { get ; set; }
  
  /// <summary>
  /// Luminance
  /// </summary>
  public Int32? LumValue { get ; set; }
  
  public Collection<Int32>? Tints { get ; set; }
  
  public Collection<Int32>? Shades { get ; set; }
  
  public Collection<Boolean>? Complements { get ; set; }
  
  public Collection<Boolean>? Inverses { get ; set; }
  
  public Collection<Boolean>? Graies { get ; set; }
  
  public Collection<Int32>? Alphas { get ; set; }
  
  public Collection<Int32>? AlphaOffsets { get ; set; }
  
  public Collection<Int32>? AlphaModulations { get ; set; }
  
  public Collection<Int32>? Hues { get ; set; }
  
  public Collection<Int32>? HueOffsets { get ; set; }
  
  public Collection<Int32>? HueModulations { get ; set; }
  
  public Collection<Int32>? Saturations { get ; set; }
  
  public Collection<Int32>? SaturationOffsets { get ; set; }
  
  public Collection<Int32>? SaturationModulations { get ; set; }
  
  public Collection<Int32>? Luminances { get ; set; }
  
  public Collection<Int32>? LuminanceOffsets { get ; set; }
  
  public Collection<Int32>? LuminanceModulations { get ; set; }
  
  public Collection<Int32>? Reds { get ; set; }
  
  public Collection<Int32>? RedOffsets { get ; set; }
  
  public Collection<Int32>? RedModulations { get ; set; }
  
  public Collection<Int32>? Greens { get ; set; }
  
  public Collection<Int32>? GreenOffsets { get ; set; }
  
  public Collection<Int32>? GreenModulations { get ; set; }
  
  public Collection<Int32>? Blues { get ; set; }
  
  public Collection<Int32>? BlueOffsets { get ; set; }
  
  public Collection<Int32>? BlueModulations { get ; set; }
  
  public Collection<Boolean>? Gammas { get ; set; }
  
  public Collection<Boolean>? InverseGammas { get ; set; }
  
}
