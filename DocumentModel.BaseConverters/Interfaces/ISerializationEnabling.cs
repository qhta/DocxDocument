namespace DocumentModel.BaseConverters;

/// <summary>
/// Interface used in XML serialization to determine whether an object should be serialized. Implementing this interface allows a class to provide custom logic for deciding if it should be included in the serialized output, which can be useful for optimizing serialization or excluding certain objects based on specific conditions.
/// </summary>
public interface ISerializationEnabling
{
  /// <summary>
  /// Determines whether the object should be serialized.
  /// </summary>
  /// <returns><see langword="true"/> if the object should be serialized; otherwise, <see langword="false"/>.</returns>
  public bool ShouldSerialize();
}
