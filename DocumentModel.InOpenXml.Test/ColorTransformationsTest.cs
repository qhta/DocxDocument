using DocumentModel.Drawings;

namespace DocumentModel.InOpenXml.Test;

using Math = System.Math;

/// <summary>
/// Comprehensive tests for all DocumentModel types implementing IColor.
/// </summary>
public class ColorTransformationsTest : BaseThemeTest
{
  /// <summary>
  /// Runs all IColor implementation tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Color Transformations Test ===\n");
    if (!TestTransformationTypeDiscovery()) return false;
    if (!TestColorModelsConversion()) return false;
    if (!TestColorTransformations()) return false;


    Console.WriteLine("All Color transformation tests passed.\n");
    return true;
  }

  /// <summary>
  /// Verifies that all known IColor implementations are discovered.
  /// </summary>
  /// <returns>True if discovery is correct; otherwise, false.</returns>
  private bool TestTransformationTypeDiscovery()
  {
    Console.WriteLine("--- ColorTransformations Type Discovery ---");
    var discovered = GetIColorTransformationTypes();
    var expected = colorTransformationsToTest.Select(t => t.GetType()).OrderBy(t => t.FullName).ToArray();

    if (!discovered.SequenceEqual(expected))

    {
      Console.WriteLine("✗ ColorTransformations type discovery FAILED");
      Console.WriteLine("Discovered:");
      foreach (var item in discovered) Console.WriteLine($"  {item}");
      Console.WriteLine("Expected:");
      foreach (var item in expected) Console.WriteLine($"  {item}");
      return false;
    }

    Console.WriteLine("✓ ColorTransformations type discovery passed\n");
    return true;
  }


  private readonly List<Type> typesToConvert =
  [
    typeof(DocumentModel.Wordprocessing.WordColor),
    typeof(DocumentModel.Wordprocessing.RgbColorHex),
    typeof(DocumentModel.Wordprocessing.SchemeColor),
    typeof(DocumentModel.Drawings.RgbColorModelHex),
    typeof(DocumentModel.Drawings.RgbColorModelPercentage),
    typeof(DocumentModel.Drawings.HslColor),

  ];

  private readonly List<ColorTransformation> colorTransformationsToTest =
  [
    new DocumentModel.Drawings.Alpha { Value = "50%"},
    new DocumentModel.Drawings.AlphaModulation { Value = "60%"},
    new DocumentModel.Drawings.AlphaOffset { Value = "20%"},
    new DocumentModel.Drawings.Blue { Value = "50%"},
    new DocumentModel.Drawings.BlueModulation { Value = "60%"},
    new DocumentModel.Drawings.BlueOffset { Value = "20%"},
    new DocumentModel.Drawings.Complement(),
    new DocumentModel.Drawings.Gamma(),
    new DocumentModel.Drawings.Gray(),
    new DocumentModel.Drawings.Green { Value = "50%"},
    new DocumentModel.Drawings.GreenModulation { Value = "60%"},
    new DocumentModel.Drawings.GreenOffset { Value = "20%"},
    new DocumentModel.Drawings.Hue { Value = "180°"},
    new DocumentModel.Drawings.HueModulation { Value = "60%"},
    new DocumentModel.Drawings.HueOffset { Value = "30°"},
    new DocumentModel.Drawings.Inverse(),
    new DocumentModel.Drawings.InverseGamma(),
    new DocumentModel.Drawings.Luminance { Value = "50%"},
    new DocumentModel.Drawings.LuminanceModulation { Value = "60%"},
    new DocumentModel.Drawings.LuminanceOffset { Value = "20%"},
    new DocumentModel.Drawings.Red { Value = "50%"},
    new DocumentModel.Drawings.RedModulation { Value = "60%"},
    new DocumentModel.Drawings.RedOffset { Value = "20%"},
    new DocumentModel.Drawings.Saturation { Value = "50%"},
    new DocumentModel.Drawings.SaturationModulation { Value = "60%"},
    new DocumentModel.Drawings.SaturationOffset { Value = "20%"},
    new DocumentModel.Drawings.Shade { Value = "40%"},
    new DocumentModel.Drawings.Tint { Value = "40%"}
  ];
  /// <summary>
  /// Tests conversion between all IColor implementations by serializing and deserializing each type to XML and comparing the results.
  /// </summary>
  /// <returns>True if all conversions pass; otherwise, false.</returns>
  private bool TestColorModelsConversion()
  {
    Console.WriteLine("--- TestColorModelsConversion ---");
    var document = CreateDocumentWithInitializedThemePart();
    var theme = document.Theme!;
    var xmlString = SerializeObjectToXml(theme);
    Console.WriteLine($"\nSerialized XML (theme):\n{xmlString}");
    var deserializedTheme = DeserializeObjectFromXml(typeof(Theme), xmlString);
    if (deserializedTheme == null)
    {
      Console.WriteLine($"✗ Xml theme deserialization returned null for '{theme.GetType().Name}'");
      return false;
    }
    if (!TestHelper.CompareTestData(typeof(Theme), theme, deserializedTheme, "testTheme", "deserialized", out var message))
    {
      Console.WriteLine($"✗ Theme/Color XML Serialization/Deserialization test FAILED: {message}");
      return false;
    }

    foreach (var baseType in typesToConvert)
    {
      IColor baseColor = CreateSampleColor(baseType);

      xmlString = SerializeObjectToXml(baseColor);
      Console.WriteLine($"\nBase color model ({baseType.Name}):\n{xmlString}");

      foreach (var otherType in typesToConvert)
      {
        IColor otherColor = (IColor)Activator.CreateInstance(otherType)!;
        if (baseColor is DMW.SchemeColor)
          Debug.Assert(true);
        otherColor.ARGB = baseColor.ARGB;
        if (otherColor is INamedColor namedOther && baseColor is INamedColor namedBase)
        {
          namedOther.Name = namedBase.Name;
        }
        if (otherColor is ITintableColor tintableOther && baseColor is ITintableColor tintableBase)
        {
          tintableOther.Tint = tintableBase.Tint;
          tintableOther.Shade = tintableBase.Shade;
        }
        xmlString = SerializeObjectToXml(otherColor);
        Console.WriteLine($"\n  Color model conversion ({baseType.Name} -> {otherType.Name}):\n{xmlString}");

        if (!TestHelper.CompareTestData(typeof(IColor), baseColor, otherColor, "testColor", "otherColor", out message))
        {
          Console.WriteLine($"✗ TestColorModelsConversion FAILED: {message}");
          return false;
        }
        if (otherColor is INamedColor && baseColor is INamedColor)
          if (!TestHelper.CompareTestData(typeof(INamedColor), baseColor, otherColor, "testColor", "otherColor", out message))
          {
            Console.WriteLine($"✗ TestColorModelsConversion FAILED: {message}");
            return false;
          }

        if (otherColor is ITransformableColor && baseColor is ITransformableColor)
          if (!TestHelper.CompareTestData(typeof(ITransformableColor), baseColor, otherColor, "testColor", "otherColor", out message))
          {
            Console.WriteLine($"✗ TestColorModelsConversion FAILED: {message}");
            return false;
          }
      }

    }

    Console.WriteLine("✓ TestColorModelsConversion passed\n");
    return true;

  }

  /// <summary>
  /// Tests the GetEffectiveColor method for all ITransformableColor implementations by creating sample colors, applying transformations, and verifying the effective color matches expectations.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  private bool TestColorTransformations()
  {
    Console.WriteLine("--- TestColorTransformations ---");
    var document = CreateDocumentWithInitializedThemePart();
    var theme = document.Theme!;
#pragma warning disable IDE0018 // Inline variable declaration
    string? message;

    foreach (var type in typesToConvert)
    {
      var baseColor = CreateSampleColor(type);
      AttachToDocumentContext(baseColor, document);
      var xmlString = SerializeObjectToXml(baseColor);
      Console.WriteLine($"\nBaseColor ({type.Name}):\n{xmlString}");
      var previousRGBA = baseColor.RGBAComponents;
      var previousHSLA = baseColor.HSLAComponents;
      Console.WriteLine($"   Base R: {previousRGBA.R}, G: {previousRGBA.G}, B: {previousRGBA.B}, A: {previousRGBA.A}");
      Console.WriteLine($"   Base H: {previousHSLA.H}, S: {previousHSLA.S}, L: {previousHSLA.L}, A: {previousHSLA.A}");


      if (baseColor is ITransformableColor transformableColor)
      {
        foreach (var transformation in colorTransformationsToTest)
        {
          transformableColor.AddTransformation(transformation);
        }
        var effectiveColor = baseColor;
        foreach (var transformation in transformableColor.GetTransformations())
        {
          Console.WriteLine($"Applying transformation: {transformation.GetType().Name}");

          var checkColor = CreateCheckColor(transformation, effectiveColor);
          effectiveColor = transformation.Transform(effectiveColor);

          var effectiveRGBA = effectiveColor.RGBAComponents;
          var effectiveHSLA = effectiveColor.HSLAComponents;
          Console.WriteLine(
            $"   Effective R: {effectiveRGBA.R}, G: {effectiveRGBA.G}, B: {effectiveRGBA.B}, A: {effectiveRGBA.A}");
          Console.WriteLine(
            $"   Effective H: {effectiveHSLA.H}, S: {effectiveHSLA.S}, L: {effectiveHSLA.L}, A: {effectiveHSLA.A}");

          var checkRGBA = checkColor.RGBAComponents;
          var checkHSLA = checkColor.HSLAComponents;
          if (!TestHelper.CompareTestData(checkHSLA, effectiveHSLA, "checkHSLA", "effectiveHSLA",
                out message))
          {
            Console.WriteLine($"✗ Color {transformation.GetType().Name} transformation test FAILED: {message}");
            return false;
          }
          if (!TestHelper.CompareTestData(checkRGBA, effectiveRGBA, "checkRGBA", "effectiveRGBA",
                out message))
          {
            Console.WriteLine($"✗ Color {transformation.GetType().Name} transformation test FAILED: {message}");
            return false;
          }
          previousRGBA = effectiveColor.RGBAComponents;
          previousHSLA = effectiveColor.HSLAComponents;
        }
      }

    }

    Console.WriteLine("✓ TestColorTransformations passed\n");
    return true;
  }

  private IColor CreateCheckColor(IColorTransformation transformation, 
    IColor baseColor)
  {
    if (transformation is Shade shade)
    {
      var l = baseColor.HSLAComponents.L * shade.Value.AsDouble();
      return new EffectiveColor ( new Degrees(baseColor.HSLAComponents.H * 360), baseColor.HSLAComponents.S, l, baseColor.HSLAComponents.A );
    }
    if (transformation is Tint tint)
    {
      var l = baseColor.HSLAComponents.L * tint.Value.AsDouble() + (1 - tint.Value.AsDouble());
      return new EffectiveColor( new Degrees(baseColor.HSLAComponents.H * 360), baseColor.HSLAComponents.S, l, baseColor.HSLAComponents.A );
    }

    if (transformation is Hue hue)
    {
      var h = hue.Value.AsDouble();
      return new EffectiveColor(new Degrees(h * 360), baseColor.HSLAComponents.S, baseColor.HSLAComponents.L, baseColor.HSLAComponents.A);
    }
    if (transformation is HueOffset hueOffset)
    {
      var h = baseColor.HSLAComponents.H;
      h += hueOffset.Value.AsDouble();
      return new EffectiveColor(new Degrees(h * 360), baseColor.HSLAComponents.S, baseColor.HSLAComponents.L, baseColor.HSLAComponents.A);
    }
    if (transformation is HueModulation hueModulation)
    {
      var h = baseColor.HSLAComponents.H;
      h *= hueModulation.Value.AsDouble();
      return new EffectiveColor(new Degrees(h * 360), baseColor.HSLAComponents.S, baseColor.HSLAComponents.L, baseColor.HSLAComponents.A);
    }

    if (transformation is Alpha alpha)
    {
      var a = alpha.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = baseColor.RGBAComponents.G, Blue = baseColor.RGBAComponents.B, Alpha = a };
    }
    if (transformation is AlphaOffset alphaOffset)
    {
      var a = baseColor.RGBAComponents.A + alphaOffset.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = baseColor.RGBAComponents.G, Blue = baseColor.RGBAComponents.B, Alpha = a };
    }
    if (transformation is AlphaModulation alphaModulation)
    {
      var a = baseColor.RGBAComponents.A * alphaModulation.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = baseColor.RGBAComponents.G, Blue = baseColor.RGBAComponents.B, Alpha = a };
    }

    if (transformation is Blue blue)
    {
      var b = blue.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = baseColor.RGBAComponents.G, Blue = b, Alpha = baseColor.RGBAComponents.A };
    }
    if (transformation is BlueOffset blueOffset)
    {
      var b = baseColor.RGBAComponents.B + blueOffset.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = baseColor.RGBAComponents.G, Blue = b, Alpha = baseColor.RGBAComponents.A };
    }
    if (transformation is BlueModulation blueModulation)
    {
      var b = baseColor.RGBAComponents.B * blueModulation.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = baseColor.RGBAComponents.G, Blue = b, Alpha = baseColor.RGBAComponents.A };
    }

    if (transformation is Green green)
    {
      var g = green.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = g, Blue = baseColor.RGBAComponents.B, Alpha = baseColor.RGBAComponents.A };
    }
    if (transformation is GreenOffset greenOffset)
    {
      var g = baseColor.RGBAComponents.G + greenOffset.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = g, Blue = baseColor.RGBAComponents.B, Alpha = baseColor.RGBAComponents.A };
    }
    if (transformation is GreenModulation greenModulation)
    {
      var g = baseColor.RGBAComponents.G * greenModulation.Value.AsDouble();
      return new EffectiveColor() { Red = baseColor.RGBAComponents.R, Green = g, Blue = baseColor.RGBAComponents.B, Alpha = baseColor.RGBAComponents.A };
    }

    if (transformation is Red red)
    {
      var r = red.Value.AsDouble();
      return new EffectiveColor() { Red = r, Green = baseColor.RGBAComponents.G, Blue = baseColor.RGBAComponents.B, Alpha = baseColor.RGBAComponents.A };
    }
    if (transformation is RedOffset redOffset)
    {
      var r = baseColor.RGBAComponents.R + redOffset.Value.AsDouble();
      return new EffectiveColor() { Red = r, Green = baseColor.RGBAComponents.G, Blue = baseColor.RGBAComponents.B, Alpha = baseColor.RGBAComponents.A };
    }
    if (transformation is RedModulation redModulation)
    {
      var r = baseColor.RGBAComponents.R * redModulation.Value.AsDouble();
      return new EffectiveColor() { Red = r, Green = baseColor.RGBAComponents.G, Blue = baseColor.RGBAComponents.B, Alpha = baseColor.RGBAComponents.A };
    }

    if (transformation is Saturation saturation)
    {
      var s = saturation.Value.AsDouble();
      return new EffectiveColor( new Degrees(baseColor.HSLAComponents.H * 360), s, baseColor.HSLAComponents.L, baseColor.HSLAComponents.A );
    }
    if (transformation is SaturationOffset saturationOffset)
    {
      var s = baseColor.HSLAComponents.S + saturationOffset.Value.AsDouble();
      return new EffectiveColor( new Degrees(baseColor.HSLAComponents.H * 360), s, baseColor.HSLAComponents.L, baseColor.HSLAComponents.A );
    }
    if (transformation is SaturationModulation saturationModulation)
    {
      var s = baseColor.HSLAComponents.S * saturationModulation.Value.AsDouble();
      return new EffectiveColor( new Degrees(baseColor.HSLAComponents.H * 360), s, baseColor.HSLAComponents.L, baseColor.HSLAComponents.A );
    }
    
    if (transformation is Luminance luminance)
    {
      var l = luminance.Value.AsDouble();
      return new EffectiveColor(new Degrees(baseColor.HSLAComponents.H * 360), baseColor.HSLAComponents.S, l, baseColor.HSLAComponents.A);
    }
    if (transformation is LuminanceOffset luminanceOffset)
    {
      var l = baseColor.HSLAComponents.L + luminanceOffset.Value.AsDouble();
      return new EffectiveColor(new Degrees(baseColor.HSLAComponents.H * 360), baseColor.HSLAComponents.S, l, baseColor.HSLAComponents.A);
    }
    if (transformation is LuminanceModulation luminanceModulation)
    {
      var l = baseColor.HSLAComponents.L * luminanceModulation.Value.AsDouble();
      return new EffectiveColor(new Degrees(baseColor.HSLAComponents.H * 360), baseColor.HSLAComponents.S, l, baseColor.HSLAComponents.A);
    }

    if (transformation is Complement)
    {
      var (h, s, l, a) = baseColor.HSLAComponents;
      h = (h + 0.5) % 1.0; // Shift hue by 180 degrees to get the complement
      return new EffectiveColor(new Degrees(h * 360), s, l, a);
    }

    if (transformation is Inverse)
    {
      var (r, g, b, a) = baseColor.RGBAComponents;
      r = 1.0 - r; // Invert red component
      g = 1.0 - g; // Invert green component
      b = 1.0 - b; // Invert blue component
      return new EffectiveColor { RGBAComponents = (r, g, b, a) };
    }

    if (transformation is Gray)
    {
      var (r, g, b, a) = baseColor.RGBAComponents;
      var grayValue = r * 0.3 + g * 0.59 + b * 0.11;
      return new EffectiveColor { RGBAComponents = (grayValue, grayValue, grayValue, a) };
    }

    if (transformation is Gamma)
    {
      var (r, g, b, a) = baseColor.RGBAComponents;
      var gammaValue = 2.2;
      r = Math.Pow(r, 1.0 / gammaValue);
      g = Math.Pow(g, 1.0 / gammaValue);
      b = Math.Pow(b, 1.0 / gammaValue);
      return new EffectiveColor { RGBAComponents = (r, g, b, a) };
    }


    if (transformation is InverseGamma)
    {
      var (r, g, b, a) = baseColor.RGBAComponents;
      var gammaValue = 2.2;
      r = Math.Pow(r, gammaValue);
      g = Math.Pow(g, gammaValue);
      b = Math.Pow(b, gammaValue);
      return new EffectiveColor { RGBAComponents = (r, g, b, a) };
    }
    return baseColor;
  }

  /// <summary>
  /// Returns all non-abstract classes in the model assembly that implement an interface named IColor.
  /// </summary>
  /// <returns>Collection of discovered IColor implementation types.</returns>
  private List<Type> GetIColorTransformationTypes()
  {
    var assembly = typeof(DocumentModel.Drawings.ColorType).Assembly;
    var colorTypes = assembly.GetTypes()
      .Where(t => !t.IsAbstract && t.GetInterfaces().Any(i => i.Name == "IColorTransformation"))
      .OrderBy(item => item.FullName).ToList();

    return colorTypes;
  }

  /// <summary>
  /// Creates representative sample data for each IColor implementation type.
  /// </summary>
  /// <param name="colorType">The concrete color implementation type.</param>
  /// <returns>A populated color instance.</returns>
  private IColor CreateSampleColor(Type colorType)
  {
    if (colorType == typeof(Drawings.HslColor))
      return new DocumentModel.Drawings.HslColor
      {
        Hue = new Degrees(210),
        Saturation = new Percentage("50%"),
        Luminance = new Percentage("40%"),
        Tint = new Percentage("20%"),
        //Shade = new Percentage("40%"),
      };

    if (colorType == typeof(Drawings.PresetColor))
      return new DocumentModel.Drawings.PresetColor
      {
        Index = PresetColors.Red,
        Tint = new Percentage("20%"),
        //Shade = new Percentage("40%"),
      };
    if (colorType == typeof(Drawings.RgbColorModelHex))
      return new DocumentModel.Drawings.RgbColorModelHex()
      {
        Value = (HexColor)0x336699,
        //Tint = new Percentage("20%"),
        Shade = new Percentage("40%"),
      };
    if (colorType == typeof(Drawings.RgbColorModelPercentage))
      return new DocumentModel.Drawings.RgbColorModelPercentage
      {
        Red = new Percentage("20%"),
        Green = new Percentage("40%"),
        Blue = new Percentage("60%"),
        Tint = new Percentage("20%"),
        //Shade = new Percentage("40%"),
      };
    if (colorType == typeof(Drawings.SchemeColor))
      return new DocumentModel.Drawings.SchemeColor
      {
        Index = SchemeColors.Accent3,
        Tint = new Percentage("20%"),
        Shade = new Percentage("40%"),
      };
    if (colorType == typeof(Drawings.SystemColor))
      return new DocumentModel.Drawings.SystemColor
      {
        Index = SystemColors.WindowText,
        //LastColor = (HexColor)0x112233,
        Tint = new Percentage("20%"),
        //Shade = new Percentage("40%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.WordColor))
      return new DocumentModel.Wordprocessing.WordColor
      {
        Value = (HexColor)0x336699,
        //ThemeColor = DMD.SchemeColors.Text1,
        Tint = new HexPercent("20%"),
        //Shade = new HexPercent("20%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.RgbColorHex))
      return new DocumentModel.Wordprocessing.RgbColorHex
      {
        Value = (HexColor)0x336699,
        Tint = new HexPercent("20%"),
        //Shade = new HexPercent("40%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.SchemeColor))
      return new DocumentModel.Wordprocessing.SchemeColor
      {
        Index = DMD.SchemeColors.Dark2,
        LastColor = (HexColor)0x336699,
        Tint = new Percentage("20%"),
        // Shade = new Percentage("40%"),
      };
    throw new NotSupportedException($"Unsupported IColor type '{colorType.FullName}'.");
  }

}
