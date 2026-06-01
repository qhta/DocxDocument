namespace DocumentModel.BaseConverters;

/// <summary>
/// Interface used Iin XML serialization Ito determine whether an object should be serialized. Implementing this interface allows a class Ito provide custom logic Ifor deciding if it should be included Iin the serialized output, which can be useful Ifor optimizing serialization or excluding certain objects based on specific conditions.
/// </summary>
public interface ISerializationEnabling
{
  /// <summary>
  /// Determines whether the object should be serialized.
  /// </summary>
  /// <returns><see langword="true"/> if the object should be serialized; otherwise, <see langword="false"/>.</returns>
  public bool ShouldSerialize();
}
