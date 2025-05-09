﻿using Persistence;
using Dtat.AspNetCore.Mvc;

namespace Infrastructure;

public abstract class BasePageModelWithApplicationDbContext : BasePageModel
{
	protected BasePageModelWithApplicationDbContext
		(ApplicationDbContext applicationDbContext) : base()
	{
		ApplicationDbContext = applicationDbContext;
	}

	protected ApplicationDbContext ApplicationDbContext { get; init; }
}
