using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kolokwium_.NHibernate;
using kolokwium_.Mapping;
using kolokwium_.dtos;


namespace kolokwium_.Api
{
    public class KolokwiumApi
    {
        public KolokwiumApi()
        {
            NHibernateBase nHibernate = new NHibernateBase();
            nHibernate.Initialize();
        }

        public void AddPost(Post post)
        {
            using (var session = NHibernateBase.Session) 
            {
                session.Save(post);
            }
        }

        public List<PostDto> GetPosts()
        {
            using (var session = NHibernateBase.Session) 
            {
                return session.Query<Post>().Select(
                    x => new PostDto
                    {
                        Topic = x.Topic,
                        Description = x.Description,
                        Type = x.Type,
                        isPremium = x.isPremium
                    }).ToList();
            }
        }

        public List<TypePostDto> GetTypes()
        {
            using (var session = NHibernateBase.Session) //tworzymy obiekt połączenie do bazy danych
            {
                return session.Query<TypePost>().Select(
                    x => new TypePostDto
                    {
                        postType = x.postType
                    }).ToList();
            }
        }
    }
}