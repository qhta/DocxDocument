namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents the application of a function or an argument in an equation that consists of a function name, such as sin or cos, and an argument.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunc?view=word-pia"/>
public interface IMathFunc : IInteropObject
{
  /// <summary>
  /// Returns the function name expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunc.fname?view=word-pia"/>
  public IMath FName { get; }
  /// <summary>
  /// Returns the function argument expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunc.e?view=word-pia"/>
  public IMath E { get; }	
}	

