namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a mathematical function or structure that Microsoft Office Word supports, such as fractions, integrals, sums, and radicals. The OMathFunction object is a member of the OMathFunctions collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction?view=word-pia"/>
public partial interface OMathFunction : InteropObject
{
  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.type?view=word-pia"/>
  public OMathFunctionType Type { get; }

  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns the collection of arguments for the equation function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.args?view=word-pia"/>
  public OMathArgs Args { get; }

  /// <summary>
  /// Returns the accent function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.acc?view=word-pia"/>
  public OMathAcc Acc { get; }

  /// <summary>
  /// Returns the bar function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.bar?view=word-pia"/>
  public OMathBar Bar { get; }

  /// <summary>
  /// Returns the box function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.box?view=word-pia"/>
  public OMathBox Box { get; }

  /// <summary>
  /// Returns the border box function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.borderbox?view=word-pia"/>
  public OMathBorderBox BorderBox { get; }

  /// <summary>
  /// Returns the delimiter function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.delim?view=word-pia"/>
  public OMathDelim Delim { get; }

  /// <summary>
  /// Returns the equation array function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.eqarray?view=word-pia"/>
  public OMathEqArray EqArray { get; }

  /// <summary>
  /// Returns the fraction function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.frac?view=word-pia"/>
  public OMathFrac Frac { get; }

  /// <summary>
  /// Returns the function-application function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.func?view=word-pia"/>
  public OMathFunc Func { get; }

  /// <summary>
  /// Returns the group character function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.groupchar?view=word-pia"/>
  public OMathGroupChar GroupChar { get; }

  /// <summary>
  /// Returns the lower-limit function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.limlow?view=word-pia"/>
  public OMathLimLow LimLow { get; }

  /// <summary>
  /// Returns the upper-limit function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.limupp?view=word-pia"/>
  public OMathLimUpp LimUpp { get; }

  /// <summary>
  /// Returns the matrix function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.mat?view=word-pia"/>
  public OMathMat Mat { get; }

  /// <summary>
  /// Returns the n-ary operator function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.nary?view=word-pia"/>
  public OMathNary Nary { get; }

  /// <summary>
  /// Returns the phantom function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.phantom?view=word-pia"/>
  public OMathPhantom Phantom { get; }

  /// <summary>
  /// Returns the pre-sub/superscript function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.scrpre?view=word-pia"/>
  public OMathScrPre ScrPre { get; }

  /// <summary>
  /// Returns the radical function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.rad?view=word-pia"/>
  public OMathRad Rad { get; }

  /// <summary>
  /// Returns the subscript function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.scrsub?view=word-pia"/>
  public OMathScrSub ScrSub { get; }

  /// <summary>
  /// Returns the subscript-superscript function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.scrsubsup?view=word-pia"/>
  public OMathScrSubSup ScrSubSup { get; }

  /// <summary>
  /// Returns the superscript function object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.scrsup?view=word-pia"/>
  public OMathScrSup ScrSup { get; }

  /// <summary>
  /// Returns the parent equation object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunction.omath?view=word-pia"/>
  public OMath OMath { get; }
}
