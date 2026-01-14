
namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OnOffType or OnOffValue element.
/// </summary>
public static class OnOffUtils
{
  /// <summary>
  /// Retrieves the boolean equivalent of the specified OpenXml Math OnOffType.
  /// </summary>
  /// <param name="element">The OpenXml Math OnOffType element to convert.</param>
  /// <returns>True if value is 'true' or 'on', false if 'false' or 'off', otherwise null.</returns>
  public static bool? AsBoolean(this DXM.OnOffType? element)
  {
    var val = element?.Val?.Value;
    if (val == null) return null;
    if (val == DXM.BooleanValues.True || val == DXM.BooleanValues.On) return true;
    if (val == DXM.BooleanValues.False || val == DXM.BooleanValues.Off) return false;
    return null;
  }

  /// <summary>
  /// Retrieves the boolean equivalent of the specified OpenXml OnOffValue.
  /// </summary>
  /// <param name="element">The OpenXml OnOffValue element to convert.</param>
  /// <returns>The boolean value, or null if the element is null.</returns>
  public static bool? AsBoolean(this DX.OnOffValue? element)
    => (element is null) ? null : (bool)element;
}
