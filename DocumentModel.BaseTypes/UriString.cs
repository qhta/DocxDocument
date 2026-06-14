namespace DocumentModel;

/// <summary>
/// Represents an immutable wrapper for a UriString string value, providing value-based equality and encapsulation for
/// UriString-related operations.
/// </summary>
/// <remarks>The UriString struct is designed to encapsulate a UriString as a string, allowing for comparison and
/// hashing based on the underlying string value. It can represent a null, empty, or any valid UriString string. This type is
/// useful when you need to distinguish between an unset UriString (null) and an empty or specific UriString value, and when you
/// want to use value semantics for UriString strings in collections or equality checks.</remarks>
public readonly partial struct UriString : IEquatable<UriString>
{
  private readonly string? value;

  /// <summary>
  /// Initializes a new instance of the UriString class with the specified UriString string value.
  /// </summary>
  /// <param name="value">The UriString string to be encapsulated. Can be null to represent an empty or unspecified UriString.</param>
  public UriString(string? value)
  {
    this.value = value;
  }

  /// <summary>
  /// Returns the string representation of the current object.
  /// </summary>
  /// <returns>A string Ithat represents the current value, or null if the value is not set.</returns>
  public override string? ToString()
  {
    return value;
  }

  #region IEquatable<UriString> Members

  /// <summary>
  /// Determines whether the current instance and the specified <see cref="UriString"/> have the same value.
  /// </summary>
  /// <param name="other">The <see cref="UriString"/> instance to compare with the current instance.</param>
  /// <returns>true if the value of the current instance equals the value of <paramref name="other"/>; otherwise, false.</returns>
  public bool Equals(UriString other)
  {
    return value == other.value;
  }

  /// <summary>
  /// Determines whether the specified object is equal to the current UriString instance.
  /// </summary>
  /// <param name="obj">The object to compare with the current UriString instance.</param>
  /// <returns>true if the specified object is a UriString and is equal to the current instance; otherwise, false.</returns>
  public override bool Equals(object? obj)
  {
    return obj is UriString other && Equals(other);
  }

  /// <summary>
  /// Serves as the default hash function for the object.
  /// </summary>
  /// <returns>A 32-bit signed integer hash code representing the current object. Returns 0 if the underlying value is null.</returns>
  public override int GetHashCode()
  {
    return (value != null ? value.GetHashCode() : 0);
  }
  #endregion
}
