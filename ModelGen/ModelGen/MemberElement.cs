﻿
using System.ComponentModel;

namespace ModelGen;

public class MemberElement : ModelElement
{
  /// <summary>
  /// Default constructor. Needed for serialization.
  /// </summary>
  public MemberElement() { }

  /// <summary>
  /// Initializing constructor
  /// </summary>
  /// <param name="name"></param>
  public MemberElement(string name): base(name)
  {
  }

  [XmlIgnore]
  public TypeInfo? DeclaringType { get => (TypeInfo?)Owner; set => Owner = value; }

  [XmlIgnore]
  public System.Reflection.MemberInfo? ReflectionInfo { [DebuggerStepThrough] get; set; }

  /// <summary>
  /// Members are usually added in ScanSource phase, however can be added in later phase.
  /// </summary>
  [DefaultValue(PPS.ScanSource)]
  public PPS AddedInPhase { [DebuggerStepThrough] get; set; } = PPS.ScanSource;

}