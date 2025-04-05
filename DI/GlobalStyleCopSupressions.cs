using System.Diagnostics.CodeAnalysis;

// Решарпер и райдер не подхватывают .editorconfig - приходится использовать код
[assembly: SuppressMessage(
    "StyleCop.CSharp.ReadabilityRules",
    "SA1101:PrefixLocalCallsWithThis",
    Justification = "У нас не нужно добавлять префикс this",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.SpacingRules",
    "SA1028:CodeMustNotContainTrailingWhitespace",
    Justification = "Это форк чужого кода",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.OrderingRules",
    "SA1200:UsingDirectivesMustBePlacedWithinNamespace",
    Justification = "Мы пока игнорируем это предупреждение - но стоит исправить",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1201:ElementsMustAppearInTheCorrectOrder",
    Justification = "Это не наш код",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1210:UsingDirectivesMustBeOrderedAlphabeticallyByNamespace",
    Justification = "Это не наш код",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.NamingRule",
    "SA1309:FieldNamesMustNotBeginWithUnderscore",
    Justification = "У нас поля должны начинаться с подчеркивания",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1313:ParameterNamesMustBeginWithLowerCaseLetter",
    Justification = "Это не наш код",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1623:PropertySummaryDocumentationMustMatchAccessors",
    Justification = "Мы не пишем Gets / sets, т.к. наша документация на русском",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1611:ElementParametersMustBeDocumented",
    Justification = "Это не наш код",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1615:ElementReturnValueMustBeDocumented",
    Justification = "Это не наш код",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1629:DocumentationTextMustEndWithAPeriod",
    Justification = "Мы не ставим точку в комментариях",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1633:FileMustHaveHeader",
    Justification = "Мы не добаваляем заголовки в каждый файл",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1636:FileHeaderCopyrightTextMustMatch",
    Justification = "Мы не добаваляем заголовки в каждый файл и поэтому нет текста копирайта",
    Scope = "module")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1642:ConstructorSummaryDocumentationMustBeginWithStandardText",
    Justification = "Мы не пишем Initializes a new..., т.к. наша документация на русском",
    Scope = "module")]