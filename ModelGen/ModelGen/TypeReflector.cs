using DocumentFormat.OpenXml;

using Namotion.Reflection;

namespace ModelGen;

public static class TypeReflector
{
  public static event ReflectionProgressEvent? OnReflection;

  private static Queue<TypeInfo> TypeQueue = new Queue<TypeInfo>();

  public static bool CancelRequest { get; set; }

  public static void ReflectTypeAsync(this TypeInfo typeInfo)
  {
    if (typeInfo.IsReflected)
      return;
    isStarted = true;
    lock (typeInfo)
    {
      if (!TypeQueue.Contains(typeInfo))
        TypeQueue.Enqueue(typeInfo);
      else
        Debug.Fail($"Type{typeInfo.Name} already in reflection queue");
      if (!isStarted) Start();
    }
  }

  private static bool isStarted; //=> ReflectionTasks is not null;
  private static bool isDone;
  private static int TaskCount = 10;
  private static Task[] ReflectionTasks = null!;
  private static int RunTrials = 100;
  public static void Start()
  {
    ReflectionTasks = new Task[TaskCount];
    for (int i = 0; i < TaskCount; i++)
    {
      ReflectionTasks[i] = new Task(() =>
      {
        var trials = RunTrials;
        do
        {
          trials--;
          if (TypeQueue.Any())
          {
            TypeInfo? typeInfo = null;
            lock (TypeQueue)
            {
              if (TypeQueue.Count > 0)
                typeInfo = TypeQueue.Dequeue();
              else
              {
                typeInfo = null;
              }
            }
            if (typeInfo != null)
            {
              ReflectType(typeInfo);
              trials = RunTrials;
            }
            else
              Thread.Sleep(10);
          }
        } while (trials > 0);
      });
      ReflectionTasks[i].Start();
    }
  }


  public static void WaitDone()
  {
    if (ReflectionTasks is not null)
      while (TypeQueue.Count > 0 && !CancelRequest)
        Task.WaitAll(ReflectionTasks, 1000);
    isDone = true;
  }

  public static void WaitForReflection(this TypeInfo typeInfo)
  {
    if (isStarted && !isDone && !CancelRequest)
    {
      int count = 10;
      while (typeInfo.IsReflected == false && (count--) > 0 && !CancelRequest)
      {
        Thread.Sleep(10);
      }
      if (!typeInfo.IsReflected)
        ReflectType(typeInfo);
    }
  }

  public static object reflectedLock = new();
  public static int reflected;
  public static void ReflectType(this TypeInfo typeInfo)
  {
    if (typeInfo.IsReflected)
      return;
    lock (reflectedLock)
    {
      reflected++;
      OnReflection?.Invoke(new ReflectionProgressInfo { Done = reflected, Waiting = TypeQueue.Count, Current = typeInfo });
    }
    var type = typeInfo.Type;
    if (type.IsEnum)
    {
      foreach (var item in type.GetFields(BindingFlags.Static | BindingFlags.Public))
      {
        if (CancelRequest)
          return;
        typeInfo.Add(new EnumInfo(item));
      }
    }
    else if ((type.IsClass || type.IsInterface || type.IsValueType) && type != typeof(string) && type != typeof(object))
    {
      foreach (var item in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
      {
        if (CancelRequest)
          return;
        if (!item.PropertyType.Name.EndsWith('&'))
          typeInfo.Add(new PropInfo(item));
      }
      if (type.BaseType != null && type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
      {
        typeInfo.BaseTypeInfo = TypeManager.RegisterType(type.BaseType, typeInfo, Semantics.Inheritance);
      }

      if (type.ContainsGenericParameters)
      {
        var genericTypeParameters = type.GetGenericArguments();
        if (genericTypeParameters.Any())
        {
          foreach (var argType in genericTypeParameters)
          {
            if (CancelRequest)
              return;
            TypeManager.RegisterType(argType, typeInfo, Semantics.GenericTypeParam);
          }
        }
      }

      if (type.IsGenericTypeParameter)
      {
        var genericTypeParamConstraints = type.GetGenericParameterConstraints();
        if (genericTypeParamConstraints.Any())
        {
          foreach (var constraint in genericTypeParamConstraints)
          {
            if (CancelRequest)
              return;
            TypeManager.RegisterType(constraint, type, Semantics.GenericTypeParamConstraint);
          }
        }
      }

      var genericTypeArguments = type.GenericTypeArguments;
      if (genericTypeArguments.Any())
      {
        int cnt = 0;
        foreach (var argType in genericTypeArguments)
        {
          if (CancelRequest)
            return;
          var argTypeInfo = TypeManager.RegisterType(argType);
          var rel = TypeManager.AddRelationship(typeInfo, argTypeInfo, Semantics.GenericTypeArg, ++cnt);
        }
      }

      var implementedInterfaces = type.GetInterfaces();
      if (implementedInterfaces.Any())
      {
        foreach (var intf in implementedInterfaces)
        {
          if (CancelRequest)
            return;
          TypeManager.RegisterType(intf, typeInfo, Semantics.Implementation);
        }
      }
    }

    var xmlDocsElement = type.GetXmlDocsElement();
    if (xmlDocsElement != null)
      CommentDocsParser.ParseDocumentation(typeInfo, xmlDocsElement);

    typeInfo.Schema = OpenXmlMetadataReader.GetOpenXmlElementSchema(typeInfo);

    if (typeInfo.Schema != null)
      ProcessElementSchema(typeInfo, typeInfo.Schema);
    /*
    else
    {
      foreach (var includeRelationship in typeInfo.GetOutgoingRelationships(Semantics.Include))
      {
        if (typeInfo.Properties == null)
          typeInfo.Properties = new OwnedCollection<PropInfo>(typeInfo);
        if (includeRelationship.IsMultiple == true)
        {
          var propName = MultipleItemsPropName(includeRelationship.Target.Name);
          if (typeInfo.Name == propName)
            propName = "Items";
          if (!typeInfo.Properties.Any(item => item.Name == propName))
          {
            var propInfo = new PropInfo(includeRelationship.Target);
            propInfo.Name = propName;
            Type propertyType = typeof(System.Collections.ObjectModel.Collection<>).MakeGenericType(new Type[] { includeRelationship.Target.Type });
            propInfo.PropertyType = TypeManager.RegisterType(propertyType);
            typeInfo.Properties.Add(propInfo);
          }
        }
        else
        {
          var propName = includeRelationship.Target.Name;
          if (typeInfo.Name == propName)
            propName = "Child" + propName;
          if (!typeInfo.Properties.Any(item => item.Name == propName))
          {
            var propInfo = new PropInfo(includeRelationship.Target);
            propInfo.Name = propName;
            typeInfo.Properties.Add(propInfo);
          }
        }
      }
    }
*/
    //foreach (var item in type.CustomAttributes)
    //  typeInfo.CustomAttributes.Add(new CustomAttribData(item));
    typeInfo.IsReflected = true;
  }

  public static void ProcessElementSchema(this TypeInfo typeInfo, ElementSchema schema)
  {
    if (schema.Main != null)
      ProcessSchemaParticle(typeInfo, schema.Main);
  }

  public static void ProcessSchemaParticle(this TypeInfo typeInfo, SchemaParticle particle)
  {
    if (particle is ItemElementParticle itemElementParticle)
    {
      //itemElementParticle.AccessProperty = CreateProperty(typeInfo, itemElementParticle);
    }
    else
    if (particle is ItemsGroupParticle itemsGroupParticle)
    {
      ScanItemsParticle(typeInfo, itemsGroupParticle);
    }
    else
    if (particle is ItemsChoiceParticle itemsChoiceParticle)
    {
      ScanItemsParticle(typeInfo, itemsChoiceParticle);
    }
    else
    if (particle is ItemsSequenceParticle itemsSequenceParticle)
    {
      ScanItemsParticle(typeInfo, itemsSequenceParticle);
    }
    else
    if (particle is ItemsAllParticle itemsAllParticle)
    {
      ScanItemsParticle(typeInfo, itemsAllParticle);
    }
  }

  public static void ScanItemsParticle(this TypeInfo typeInfo, ItemsParticle particle)
  {
    foreach (var item in particle.Items)
    {
      if (CancelRequest)
        return;
      ProcessSchemaParticle(typeInfo, item);
    }
  }

  public static PropInfo? CreateProperty(this TypeInfo typeInfo, ItemElementParticle particle)
  {
    var targetType = particle.ItemType;
    if (particle.IsMultiple)
    {
      var propName = PluralizeName(targetType.Name);
      if (typeInfo.Name == propName)
        propName = "Items";
      var existingProp = typeInfo.Properties?.FirstOrDefault(item => item.Name == propName);
      if (existingProp == null)
      {
        var propInfo = new PropInfo(propName, targetType);
        Type propertyType = typeof(Collection<>).MakeGenericType(new Type[] { targetType.Type });
        //if (particle.MaxOccurs != null || particle.MinOccurs != null)
        {
          propInfo.Add(new CustomAttribInfo(
            new DocumentModel.Attributes.CollectionConstraintAttribute
            {
              MinCount = particle.MinOccurs,
              MaxCount = particle.MaxOccurs,
            }));
        }
        propInfo.PropertyType = TypeManager.RegisterType(propertyType);
        propInfo.IsConstrained = true;
        typeInfo.Add(propInfo);
        return propInfo;
      }
      else
      {
        existingProp.IsConstrained = true;
        return existingProp;
      }
    }
    else
    {
      var propName = targetType.Name;
      if (typeInfo.Name == propName)
        propName = "Child" + propName;
      if (typeInfo.Properties != null)
      {
        var existingProp = typeInfo.Properties.FirstOrDefault(item => item.Name == propName);
        if (existingProp == null)
        {
          var propInfo = new PropInfo(propName, targetType);
          propInfo.IsConstrained = true;
          typeInfo.Properties.Add(propInfo);
          return propInfo;
        }
        else
        {
          existingProp.IsConstrained = true;
          return existingProp;
        }
      }
    }
    return null;
  }

  public static string PluralizeName(string aName)
  {
    if (aName.EndsWith("y"))
      return aName.Substring(0, aName.Length - 1) + "ies";
    else if (aName.EndsWith("ss"))
      return aName + "es";
    if (!aName.EndsWith("s"))
      return aName + "s";
    return aName;
  }

  public static string SingularizeName(string aName)
  {
    if (aName.EndsWith("ies"))
      return aName.Substring(0, aName.Length - 3) + "y";
    else if (aName.EndsWith("sses"))
      return aName.Substring(0, aName.Length - 2);
    else if (aName.EndsWith("s"))
      return aName.Substring(0, aName.Length - 1);
    else return aName;
  }

  //private static bool GenDocumentationComments(TypeInfo typeInfo)
  //{
  //  var documentation = typeInfo.Type.GetXmlDocsElement();
  //  if (documentation != null)
  //  {
  //    var summary = DocumentationReader.GetSummaryFirstPara(documentation);
  //    typeInfo.Summary = summary;
  //    return true;
  //  }
  //  return false;
  //}
}