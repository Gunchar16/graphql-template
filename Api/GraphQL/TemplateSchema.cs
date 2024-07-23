using GraphQL.Types;

namespace Api.GraphQL;

public class TemplateSchema : Schema
{
    public TemplateSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<TemplateQuery>();
        Mutation = serviceProvider.GetRequiredService<TemplateMutation>();
    }

}