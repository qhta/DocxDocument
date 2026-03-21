namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a type of smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype?view=word-pia"/>
public interface SmartTagType : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The smart tag actions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype.smarttagactions?view=word-pia"/>
  public SmartTagActions SmartTagActions { get; }
  /// <summary>
  /// The smart tag recognizers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype.smarttagrecognizers?view=word-pia"/>
  public SmartTagRecognizers SmartTagRecognizers { get; }
  /// <summary>
  /// The friendly name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagtype.friendlyname?view=word-pia"/>
  public string FriendlyName { get; }

}
