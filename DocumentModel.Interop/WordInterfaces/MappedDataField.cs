namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single mapped data field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield?view=word-pia"/>
public interface MappedDataField : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// The data field name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.datafieldname?view=word-pia"/>
  public string DataFieldName { get; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.value?view=word-pia"/>
  public string Value { get; }
  /// <summary>
  /// The data field index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mappeddatafield.datafieldindex?view=word-pia"/>
  public int DataFieldIndex { get; set; }

}
