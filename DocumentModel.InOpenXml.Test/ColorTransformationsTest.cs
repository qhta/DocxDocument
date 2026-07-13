using DocumentModel.Drawings;

using Path = System.IO.Path;

namespace DocumentModel.InOpenXml.Test;

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
    var expected = new List<Type>
    {
      typeof(DocumentModel.Drawings.Alpha),
      typeof(DocumentModel.Drawings.AlphaModulation),
      typeof(DocumentModel.Drawings.AlphaOffset),
      typeof(DocumentModel.Drawings.Shade),
      typeof(DocumentModel.Drawings.Tint),
    };


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


  private readonly List<Type> typesToConvert = new List<Type>
  {

    typeof(DocumentModel.Drawings.RgbColorModelHex),
    typeof(DocumentModel.Drawings.RgbColorModelPercentage),
    typeof(DocumentModel.Drawings.HslColor),
    typeof(DocumentModel.Wordprocessing.WordColor),
    typeof(DocumentModel.Wordprocessing.RgbColorHex),
    typeof(DocumentModel.Wordprocessing.SchemeColor),
  };

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
        if (otherColor is ITransformableColor tintableOther && baseColor is ITransformableColor tintableBase)
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
        var effectiveColor = baseColor;
        foreach (var transformation in transformableColor.GetTransformations())
        {
          Console.WriteLine($"Applying transformation: {transformation.GetType().Name}");

          effectiveColor = transformation.Transform(effectiveColor);

          var effectiveRGBA = effectiveColor.RGBAComponents;
          var effectiveHSLA = effectiveColor.HSLAComponents;
          Console.WriteLine(
            $"   Effective R: {effectiveRGBA.R}, G: {effectiveRGBA.G}, B: {effectiveRGBA.B}, A: {effectiveRGBA.A}");
          Console.WriteLine(
            $"   Effective H: {effectiveHSLA.H}, S: {effectiveHSLA.S}, L: {effectiveHSLA.L}, A: {effectiveHSLA.A}");
          var checkColor = effectiveColor;

          if (transformation is Shade shade)
          {
            var l = previousHSLA.L * shade.Value.AsDouble();
            checkColor = new HslColor() { Hue = effectiveHSLA.H*360, Saturation = effectiveHSLA.S, Luminance = l, Alpha = effectiveHSLA.A };
          }
          else if (transformation is Tint tint)
          {
            var l = previousHSLA.L * tint.Value.AsDouble() + (1 - tint.Value.AsDouble());
            checkColor = new HslColor() { Hue = effectiveHSLA.H * 360, Saturation = effectiveHSLA.S, Luminance = l, Alpha = effectiveHSLA.A };
          }
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
