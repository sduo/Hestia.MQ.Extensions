using Hestia.MQ.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Hestia.MQ
{
    public static class MessageQueueExtensions
    {
        public static IMessageQueue GetMessageQueue(this IServiceProvider services, string name, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
        {
            return services.GetServices<IMessageQueue>().FirstOrDefault(mq => string.Equals(mq.Name, name, comparison));
        }

    }
}
