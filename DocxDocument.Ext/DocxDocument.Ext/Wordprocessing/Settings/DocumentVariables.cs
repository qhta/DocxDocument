namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifiesspecifies the presence of documentvariables in a WordprocessingML. 
/// A document variable is a storage location for arbitrary customer data in name/value pairs 
/// that is persisted in a given WordprocessingML document.
/// [Note: This mechanism is maintained for legacy compatibility only, and should be avoided 
/// in favor of the custom XML data support defined in /IEC 29500. end note]
/// </summary>
[Obsolete]
public partial class DocumentVariables : NamedElementCollection<DXW.DocumentVariables, DXW.DocumentVariable, DMW.DocumentVariable>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public DocumentVariables() : base() { }

  public DocumentVariables(DX.OpenXmlElement openXmlElement) : base(openXmlElement) { }

  public DocumentVariables(DXW.DocumentVariables openXmlElement) : base(openXmlElement) { }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Dictionary-like method to get a value of the defined variable.
  /// </summary>
  /// <param name="key"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  public bool TryGetValue(string key, [MaybeNullWhen(false)][NotNullWhen(true)] out string? value)
  {
    var ok = base.TryGetValue(key, out var documentVariable);
    if (ok && documentVariable!=null)
      value = documentVariable.Val;
    else
      value = null;
    return ok;

  }
}
