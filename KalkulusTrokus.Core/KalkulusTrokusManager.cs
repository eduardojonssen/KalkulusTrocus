﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using KalkulusTrokus.Core.Response;
using KalkulusTrokus.Core.Request;

namespace KalkulusTrokus.Core
{
	public class KalkulusTrokusManager
	{
		public CalculateTrokusResponse CalculateTrokus(CalculateTrokusRequest request)
		{
			CalculateTrokusResponse response = new CalculateTrokusResponse();

			try
			{
				// Verifica se os dados recebidos são válidos.
				if (request.IsValid == false)
				{
					response.Reports = request.ValidationReport;
					return response;
				}

				LessCurrencyTokenChangeMachine changeMachine = new LessCurrencyTokenChangeMachine();

				Change change = new Change();
				change.ItemWithMonetaryValueCollection = changeMachine.CalculateChanges(request.ProductAmountInCents, request.PaidAmountInCents).ToList();
				change.ChangeAmount = change.ItemWithMonetaryValueCollection.Sum(i => i.AmountInCents);

				response.Change = change;
				response.IsValid = true;
			}
			catch (Exception ex) {
				throw;
				// TODO: Implementar tratamento.
			}

			return response;
		}
	}
}

