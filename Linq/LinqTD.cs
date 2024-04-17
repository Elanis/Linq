namespace Linq {
	public static class LinqTD {
		/**
		 * Cette fonction doit filtrer la séquence pour ne garder que les entrées commencant par une
		 * lettre fournie en parametre
		 */
		public static IEnumerable<string> FilterElementsBeginningWithSpecificLetter(IEnumerable<string> sequence, char letter) {
			//return sequence.Where(s => s.Substring(0, 1) == letter.ToString());
			//return sequence.Where(s => s[..1] == letter.ToString());

			//return sequence.Where(x => x.First() == letter);
			//return sequence.Where(x => x.ToCharArray()[0] == letter);
			//return sequence.Where(x => x[0] == letter);
			//return sequence.Where(elt => char.Parse(elt.Substring(0, 1)) != letter);

			return sequence.Where(s => s.StartsWith(letter));
		}

		/**
		 * Cette fonction doit retourner le premier element de la séquence de la taille fournie en parametre
		 */
		public static string? FirstElementOfLengthI(IEnumerable<string> sequence, int size) {
			return sequence.FirstOrDefault(x => x.Length == size);

			//return sequence.Where(x => x.Length == size).FirstOrDefault();

			/*
			var test = sequence.Where(x => x.Length == size);
			//if (test.Count() > 0) {
			if (test.Any()) {
					return test.First();
			}
			return null;
			*/
		}

		/**
		 * Cette fonction doit retourner la moyenne de la séquence fournie en paramètre
		 */
		public static double AverageOfSequence(IEnumerable<int> intSequence) {
			return intSequence.Average();

			//return intSequence.Sum() / intSequence.Count();
			//return intSequence.Average(x => x);
		}

		/**
		 * Cette fonction doit retourner la moyenne des éléments uniques (sans les duplications) de la séquence fournie en paramètre
		 */
		public static double AverageOfUniqueSequenceElements(IEnumerable<int> intSequence) {
			return intSequence.Distinct().Average();

			// return intSequence.ToHashSet().Average();
		}

		/**
		 * Cette fonction doit retourner un tuple (min, max) de la séquence
		 */
		public static (int, int) MinMaxOfSequence(IEnumerable<int> intSequence) {
			return (
				intSequence.Min(),
				intSequence.Max()
			);

			/*return (
				intSequence.Order().FirstOrDefault(),
				intSequence.Order().LastOrDefault()
			);*/
		}

		/**
		 * Cette fonction doit retourner la liste des ids des objets de la séquence
		 */
		public static IEnumerable<int> IdsListOfSequence(IEnumerable<DummyModel> objectSequence) {
			return objectSequence.Select(x => x.Id);
		}

		/**
		 * Cette fonction retourne l'age moyen dans la séquence pour les objets non supprimés
		 */
		public static double AgeAverageOfSequence(IEnumerable<DummyModel> objectSequence) {
			/*return objectSequence
				.Where(x => !x.IsDeleted)
				.Select(x => x.Age).Average();*/

			return objectSequence
				.Where(x => !x.IsDeleted)
				.Average(x => x.Age);
		}

		/**
		 * Cette fonction retourne vrai si l'un des membres dans la séquence a un age egal à celui donné en paramètres
		 */
		public static bool DoesSomeonesHasASpecificAge(IEnumerable<DummyModel> objectSequence, int age) {
			//return objectSequence.FirstOrDefault(x => x.Age == age) != null;
			return objectSequence.Any(x => x.Age == age);
			//return objectSequence.Count(x => x.Age == age) > 1;

			/*
			return (
				from obj in objectSequence
				where obj.Age == age
				select obj
			).Any();
			*/
		}
	}
}
