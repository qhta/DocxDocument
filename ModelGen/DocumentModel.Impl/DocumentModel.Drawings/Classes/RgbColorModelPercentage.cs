namespace DocumentModel.Drawings;

/// <summary>
/// RGB Color Model - Percentage Variant.
/// </summary>
public class RgbColorModelPercentageImpl: ModelElementImpl, RgbColorModelPercentage
{
  public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Red
  /// </summary>
  public Int32? RedPortion
  {
    get => (Int32?)OpenXmlElement?.RedPortion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RedPortion = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Green
  /// </summary>
  public Int32? GreenPortion
  {
    get => (Int32?)OpenXmlElement?.GreenPortion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GreenPortion = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Blue
  /// </summary>
  public Int32? BluePortion
  {
    get => (Int32?)OpenXmlElement?.BluePortion?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BluePortion = (System.Int32?)value;
    }
  }
  
  public Collection<Int32>? Tints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? Shades
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? Complements
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? Inverses
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? Graies
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? Alphas
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? AlphaOffsets
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? AlphaModulations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? Hues
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? HueOffsets
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? HueModulations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? Saturations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? SaturationOffsets
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? SaturationModulations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? Luminances
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? LuminanceOffsets
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? LuminanceModulations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? Reds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? RedOffsets
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? RedModulations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? Greens
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? GreenOffsets
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? GreenModulations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? Blues
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? BlueOffsets
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Int32>? BlueModulations
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? Gammas
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? InverseGammas
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
