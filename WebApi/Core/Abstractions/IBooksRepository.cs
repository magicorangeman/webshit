﻿using Core.Api.Models;

namespace BookStore.DataAccess.Repositories;

public interface IBooksRepository
{
	Task<List<Book>> Get();
	Task<Guid> Create(Book book);
	Task<Guid> Update(Guid id, string title, string description, decimal price);
	Task<Guid> Delete(Guid id);
}