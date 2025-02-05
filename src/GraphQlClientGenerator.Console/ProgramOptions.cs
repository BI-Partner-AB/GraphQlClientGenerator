﻿namespace GraphQlClientGenerator.Console;

public class ProgramOptions
{
    public string OutputPath { get; set; }
    public string Namespace { get; set; }
    public string ServiceUrl { get; set; }
    public string SchemaFileName { get; set; }
    public string HttpMethod { get; set; }
    public ICollection<string> Header { get; set; }
    public string ClassPrefix { get; set; }
    public string ClassSuffix { get; set; }
    public CSharpVersion CSharpVersion { get; set; }
    public MemberAccessibility MemberAccessibility { get; set; }
    public OutputType OutputType { get; set; }
    public bool PartialClasses { get; set; }
    public ICollection<string> ClassMapping { get; set; }
    public IdTypeMapping IdTypeMapping { get; set; }
    public FloatTypeMapping FloatTypeMapping { get; set; }
    public JsonPropertyGenerationOption JsonPropertyAttribute { get; set; }
}