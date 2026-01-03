namespace DocumentModel;

/// <summary>
/// Represents a hexadecimal character and provides methods for conversion and comparison operations.
/// </summary>
/// <remarks>Implementations of this interface support conversion to various types and equality comparison with
/// other hexadecimal characters. This interface is typically used to abstract hexadecimal character handling in
/// parsing, formatting, or validation scenarios.</remarks>
public interface IHexChar : IConvertible, IEquatable<IHexChar>
{
}