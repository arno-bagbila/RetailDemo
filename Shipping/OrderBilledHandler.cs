﻿using Messages;
using NServiceBus;
using NServiceBus.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shipping {
    public class OrderBilledHandler : IHandleMessages<OrderBilled> {
        static ILog log = LogManager.GetLogger<OrderBilled>();

        public Task Handle(OrderBilled message, IMessageHandlerContext context) {
            log.Info($"Received OrderBilled, OrderId = {message.OrderId} - Should we ship now?");
            return Task.CompletedTask;
        }
    }
}
