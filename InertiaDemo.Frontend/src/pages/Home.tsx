import { Navigation } from '../components/Navigation';
import { page } from '../utils/page';
import type { HomeDto } from '../types/dtos/home-dto';

const Home = page<HomeDto>(({ title }) => {
  return (
    <>
      <Navigation />
      <p>{title}</p>
    </>
  );
});

export default Home;
