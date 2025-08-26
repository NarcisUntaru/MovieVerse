import React from 'react';

// Example movie data (replace with API data later)
const movies = [
    { id: 1, title: 'Inception', year: 2010, poster: 'https://via.placeholder.com/150' },
    { id: 2, title: 'Interstellar', year: 2014, poster: 'https://via.placeholder.com/150' },
    { id: 3, title: 'The Dark Knight', year: 2008, poster: 'https://via.placeholder.com/150' },
    { id: 4, title: 'Tenet', year: 2020, poster: 'https://via.placeholder.com/150' },
];

const Home = () => {
    return (
        <div className="home">
            {/* Header */}
            <header className="home-header" style={{ padding: '20px', textAlign: 'center', backgroundColor: '#111', color: '#fff' }}>
                <h1>Movie Platform</h1>
            </header>

            {/* Hero Section */}
            <section className="hero" style={{ padding: '50px', textAlign: 'center', backgroundColor: '#222', color: '#fff' }}>
                <h2>Discover Your Next Favorite Movie</h2>
                <p>Explore, favorite, and watch trailers of your favorite films.</p>
            </section>

            {/* Movies Grid */}
            <section className="movies-grid" style={{ display: 'grid', gridTemplateColumns: 'repeat(auto-fit, minmax(150px, 1fr))', gap: '20px', padding: '20px' }}>
                {movies.map((movie) => (
                    <div key={movie.id} className="movie-card" style={{ textAlign: 'center', backgroundColor: '#333', padding: '10px', borderRadius: '8px', color: '#fff' }}>
                        <img src={movie.poster} alt={movie.title} style={{ width: '100%', borderRadius: '5px' }} />
                        <h3>{movie.title}</h3>
                        <p>{movie.year}</p>
                    </div>
                ))}
            </section>
        </div>
    );
};

export default Home;
