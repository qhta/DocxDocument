namespace DocxDocument.Model.Drawing;

public class RgbColorModelHex
{
  /// <summary> 
  /// Hex value of the color
  ///</summary> 
  [XmlAttribute]
  public HexBinary? Val { get; set; }

  /// <summary> 
  /// Specifies a lighter version of its input color. A 10% tint is 10% of the input color combined with 90% white.
  ///</summary> 
  [XmlAttribute]
  public Percentage? Tint { get; set; }

  /// <summary> 
  /// Specifies a darker version of its input color. A 10% shade is 10% of the input color combined with 90% black.
  ///</summary> 
  [XmlAttribute]
  public Percentage? Shade { get; set; }

  /// <summary> 
  /// Specifies that the color rendered should be the complement of its input color with the complement being defined as such. Two colors are called complementary if, when mixed they produce a shade of grey. For instance, the complement of red which is (255, 0, 0) is cyan which is (0, 255, 255).
  ///</summary> 
  [XmlAttribute]
  public bool? Complement { get; set; }

  /// <summary> 
  /// Specifies the inverse of its input color.
  ///</summary> 
  [XmlAttribute]
  public bool? Inverse { get; set; }

  /// <summary> 
  /// Specifies a grayscale of its input color, taking into relative intensities of the red, green, and blue primaries.
  ///</summary> 
  [XmlAttribute]
  public bool? Gray { get; set; }

  /// <summary> 
  /// Specifies its input color with the specific opacity, but with its color unchanged.
  ///</summary> 
  [XmlAttribute]
  public Percentage? Alpha { get; set; }

  /// <summary> 
  /// Specifies a more or less opaque version of its input color. Increases or decreases the input alpha percentage by the specified percentage offset. A 10% alpha offset increases a 50% opacity to 60%. A -10% alpha offset decreases a 50% opacity to 40%. The transformed alpha values are limited to a range of 0 to 100%. A 10% alpha offset increase to a 100% opaque object still results in 100% opacity.
  ///</summary> 
  [XmlAttribute]
  public Percentage? AlphaOffset { get; set; }

  /// <summary> 
  /// Specifies a more or less opaque version of its input color. An alpha modulate never increases the alpha beyond 100%. A 200% alpha modulate makes a input color twice as opaque as before. A 50% alpha modulate makes a input color half as opaque as before.
  ///</summary> 
  [XmlAttribute]
  public Percentage? AlphaModulation { get; set; }

  /// <summary> 
  /// Specifies the input color with the specified hue, but with its saturation and luminance unchanged.
  ///</summary> 
  [XmlAttribute]
  public Angle? Hue { get; set; }

  /// <summary> 
  /// Specifies the input color with its hue shifted, but with its saturation and luminance unchanged.
  ///</summary> 
  [XmlAttribute]
  public Angle? HueOffset { get; set; }

  /// <summary> 
  /// Specifies the input color with its hue modulated by the given percentage. A 50% hue modulate decreases the angular hue value by half. A 200% hue modulate doubles the angular hue value.
  ///</summary> 
  [XmlAttribute]
  public Percentage? HueModulation { get; set; }

  /// <summary> 
  /// Specifies the input color with the specified saturation, but with its hue and luminance unchanged. Typically saturation values fall in the range [0%, 100%].
  ///</summary> 
  [XmlAttribute]
  public Percentage? Saturation { get; set; }

  /// <summary> 
  /// Specifies the input color with its saturation shifted, but with its hue and luminance unchanged. A 10% offset to 20% saturation yields 30% saturation.
  ///</summary> 
  [XmlAttribute]
  public Percentage? SaturationOffset { get; set; }

  /// <summary> 
  /// Specifies the input color with its saturation modulated by the given percentage. A 50% saturation modulate reduces the saturation by half. A 200% saturation modulate doubles the saturation.
  ///</summary> 
  [XmlAttribute]
  public Percentage? SaturationModulation { get; set; }

  /// <summary> 
  /// Specifies the input color with the specified luminance, but with its hue and saturation unchanged. Typically luminance values fall in the range [0%, 100%].
  ///</summary> 
  [XmlAttribute]
  public Percentage? Luminance { get; set; }

  /// <summary> 
  /// Specifies the input color with its luminance shifted, but with its hue and saturation unchanged.
  ///</summary> 
  [XmlAttribute]
  public Percentage? LuminanceOffset { get; set; }

  /// <summary> 
  /// Specifies the input color with its luminance modulated by the given percentage. A 50% luminance modulate reduces the luminance by half. A 200% luminance modulate doubles the luminance.
  ///</summary> 
  [XmlAttribute]
  public Percentage? LuminanceModulation { get; set; }

  /// <summary> 
  /// Specifies the input color with the specified red component, but with its green and blue color components unchanged.
  ///</summary> 
  [XmlAttribute]
  public Percentage? Red { get; set; }

  /// <summary> 
  /// Specifies the input color with its red component shifted, but with its green and blue color components unchanged.
  ///</summary> 
  [XmlAttribute]
  public Percentage? RedOffset { get; set; }

  /// <summary> 
  /// Specifies the input color with its red component modulated by the given percentage. A 50% red modulate reduces the red component by half. A 200% red modulate doubles the red component.
  ///</summary> 
  [XmlAttribute]
  public Percentage? RedModulation { get; set; }

  /// <summary> 
  /// Specifies the input color with the specified green component, but with its red and blue color components unchanged.
  ///</summary> 
  [XmlAttribute]
  public Percentage? Green { get; set; }

  /// <summary> 
  /// Specifies the input color with the specified green component, but with its red and blue color components unchanged.
  ///</summary> 
  [XmlAttribute]
  public Percentage? GreenOffset { get; set; }

  /// <summary> 
  /// Specifies the input color with its green component modulated by the given percentage. A 50% green modulate reduces the green component by half. A 200% green modulate doubles the green component.
  ///</summary> 
  [XmlAttribute]
  public Percentage? GreenModulation { get; set; }

  /// <summary> 
  /// Specifies the input color with the specific blue component, but with the red and green color components unchanged.
  ///</summary> 
  [XmlAttribute]
  public Percentage? Blue { get; set; }

  /// <summary> 
  /// Specifies the input color with its blue component shifted, but with its red and green color components unchanged.
  ///</summary> 
  [XmlAttribute]
  public Percentage? BlueOffset { get; set; }

  /// <summary> 
  /// Specifies the input color with its blue component modulated by the given percentage. A 50% blue modulate reduces the blue component by half. A 200% blue modulate doubles the blue component.
  ///</summary> 
  [XmlAttribute]
  public Percentage? BlueModulation { get; set; }

  /// <summary> 
  /// Specifies that the output color rendered by the generating application should be the sRGB gamma shift of the input color.
  ///</summary> 
  [XmlAttribute]
  public bool? Gamma { get; set; }

  /// <summary> 
  /// Specifies that the output color rendered by the generating application should be the inverse sRGB gamma shift of the input color.
  ///</summary> 
  [XmlAttribute]
  public bool? InverseGamma { get; set; }


}