﻿using Castle.DynamicProxy;
using Core.Logging;
using Core.Logging.Log4Net;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;

namespace Core.Aspects.Autofac.Exception
{
    public class ExceptionLogAspect : MethodInterception
    {
        private LoggerServiceBase _loggerServiceBase;

        public ExceptionLogAspect(Type loggerService)
        {
            if (loggerService.BaseType != typeof(LoggerServiceBase))
            {
                throw new System.Exception("Wrong logger type");
            }

            _loggerServiceBase = (LoggerServiceBase)Activator.CreateInstance(loggerService);
        }
        protected override void OnException(IInvocation invocation, System.Exception e)
        {
            LogDetailWithException logDetailWithException = GetLogDetail(invocation);
            logDetailWithException.ExceptionMessage = e.Message;
            _loggerServiceBase.Error(logDetailWithException);
        }

        private LogDetailWithException GetLogDetail(IInvocation invocation)
        {
            var logParameters = new List<LogParameter>();

            for (int i = 0; i < invocation.Arguments.Length; i++)
            {
                logParameters.Add(new LogParameter
                {
                    Name = invocation.GetConcreteMethod().GetParameters()[i].Name,
                    Value = invocation.Arguments[i],
                    Type = invocation.Arguments[i].GetType().Name,
                });
            }
            //todo: tokendan username al
            var logDetailWithException = new LogDetailWithException
            {
                UserName = "Emine",
                MethodName = invocation.Method.Name,
                LogParameters = logParameters,
                TransactionDate = DateTime.Now
            };

            return logDetailWithException;
        }
    }
}
