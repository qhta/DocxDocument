namespace DocumentModel.Utils;

/// <summary>
/// This static class contains extension operations to be performed on a OnOffType or OnOffValue element.
/// </summary>
public static class OnOffUtils
{
  public static bool? AsBoolean(this DXM.OnOffType? element)
  {
    var val = element?.Val?.Value;
    if (val == null) return null;
    if (val == DXM.BooleanValues.True || val == DXM.BooleanValues.On) return true;
    if (val == DXM.BooleanValues.False || val == DXM.BooleanValues.Off) return false;
    return null;
  }

  public static bool? AsBoolean(this DX.OnOffValue? element)
    => (element is null) ? null : (bool)element;
}
