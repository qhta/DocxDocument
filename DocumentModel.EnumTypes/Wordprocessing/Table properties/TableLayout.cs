namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableLayoutValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues))]
public enum TableLayoutType
{
  /// <summary>
  ///   Fixed Width Table Layout.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues.Fixed))]
  Fixed = 1,

  /// <summary>
  ///   AutoFit Table Layout.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues.Autofit))]
  Autofit
}